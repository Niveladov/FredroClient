﻿using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.Services;
using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.Models;
using FredroClient.Models.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FredroClient.Forms
{
    internal sealed partial class frmSchedule : FredroBaseXtraForm
    {
        private GridHitInfo _downHitInfo;

        public frmSchedule()
        {
            InitializeComponent();
            InitSchedulers();
            InitGrids();
            InitEvents();
        }

        private void FrmSchedule_Load(object sender, EventArgs e)
        {
            schedulerMain.Start = DateTime.Today;
            schedulerMain.TimelineView.Scales[4].Width = schedulerMain.Bounds.Width;
            schedulerMain.TimelineView.Scales[5].Width = schedulerMain.Bounds.Width / 24;
            schedulerMain.ActiveView.LayoutChanged();
        }

        private void InitEvents()
        {
            gvFreeDeals.MouseDown += GvFreeDeals_MouseDown;
            gvFreeDeals.MouseMove += GvFreeDeals_MouseMove;
            
            schedulerMain.AppointmentDrop += SchedulerMain_AppointmentDrop;
            schedulerMain.AllowAppointmentConflicts += ScchedulerMain_AllowAppointmentConflicts;
        }

        private void InitSchedulers()
        {
            storageMain.Resources.DataSource = FredroHelper.GetAllViewVehicles();
            storageMain.Resources.Mappings.Id = nameof(ViewVehicle.Id);
            storageMain.Resources.Mappings.Caption = nameof(ViewVehicle.Name);
            storageMain.Resources.Mappings.ParentId = nameof(ViewVehicle.ParentId);
            
            storageMain.Appointments.DataSource = FredroHelper.GetAssignedDeals();
            storageMain.Appointments.Mappings.AppointmentId = nameof(Deal.Id);
            storageMain.Appointments.Mappings.ResourceId = nameof(Deal.VehicleId);
            storageMain.Appointments.Mappings.Subject = nameof(Deal.Route);
            storageMain.Appointments.Mappings.Start = nameof(Deal.DateStart);
            storageMain.Appointments.Mappings.End = nameof(Deal.DateEnd);
            storageMain.Appointments.Mappings.Description = nameof(Deal.Description);
            storageMain.Appointments.Mappings.Status = nameof(Deal.DealStatusId);

            storageMain.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("Id", nameof(Deal.Id)));
        }

        private void InitGrids()
        {
            gcFreeDeals.DataSource = FredroHelper.GetNotAssignedDeals();
        }

        private SchedulerDragData GetDragData(GridView view)
        {
            int rowHandle = view.FocusedRowHandle;
            if (!view.IsDataRow(rowHandle)) return null;

            var row = view.GetRow(rowHandle) as Deal;
            Appointment apt = storageMain.CreateAppointment(AppointmentType.Normal);
            apt.Subject = row.Route;
            apt.Start = row.DateStart.Value;
            apt.End = row.DateEnd.Value;
            apt.Description = row.Description;
            apt.CustomFields["Id"] = row.Id;

            AppointmentBaseCollection appointments = new AppointmentBaseCollection();
            appointments.Add(apt);
            var result = new SchedulerDragData(appointments, 0);
            return result;
        }

        private void GvFreeDeals_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _downHitInfo != null)
            {
                GridView view = sender as GridView;
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(_downHitInfo.HitPoint.X - dragSize.Width / 2,
                    _downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    schedulerMain.OptionsCustomization.AllowAppointmentConflicts = AppointmentConflictsMode.Custom;
                    var dragData = GetDragData(view);
                    if (dragData != null)
                    {
                        view.GridControl.DoDragDrop(dragData, DragDropEffects.All);
                        _downHitInfo = null;
                    }
                }
            }
        }

        private void GvFreeDeals_MouseDown(object sender, MouseEventArgs e)
        {
            if (schedulerMain.ActiveView is TimelineView)
            {
                GridView view = sender as GridView;
                _downHitInfo = null;

                GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
                if (ModifierKeys != Keys.None) return;
                if (e.Button == MouseButtons.Left && hitInfo.InRow && hitInfo.HitTest != GridHitTest.RowIndicator)
                {
                    _downHitInfo = hitInfo;
                }
            }
        }

        private void ScchedulerMain_AllowAppointmentConflicts(object sender, AppointmentConflictEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private bool CheckIfResourceIsBusy(object resourceId, DateTime start, DateTime end)
        {
            var appointments = storageMain.Appointments.Items.Where(x => !(x.ResourceId is EmptyResource) &&
            x.ResourceId.Equals(resourceId) && (x.End > start && x.Start < end));
            var itHas = appointments.Any();
            return itHas;
        }

        private async void SchedulerMain_AppointmentDrop(object sender, AppointmentDragEventArgs e)
        {
            try
            {
                if (e.EditedAppointment.ResourceId is EmptyResource || Convert.ToInt32(e.EditedAppointment.ResourceId) <= 0)
                {
                    FredroMessageBox.ShowError("Заяка не будет назначена: выбран пустой ресурс(ТС)");
                    e.Allow = false;
                    return;
                }
                var start = e.SourceAppointment.Start;
                if (start <= DateTime.Now)
                {
                    FredroMessageBox.ShowError("Заяка не будет назначена: невозможно назначить заяку на прошедшее время");
                    e.Allow = false;
                    return;
                }
                var end = e.SourceAppointment.End;
                var vehicleId = Convert.ToInt32(e.EditedAppointment.ResourceId);
                if (CheckIfResourceIsBusy(vehicleId, start, end))
                {
                    FredroMessageBox.ShowError("Заяка не будет назначена: выбранный ресурс(ТС) занят");
                    e.Allow = false;
                    return;
                }
                var sourceDealId = e.SourceAppointment.Id;
                if (sourceDealId == null)
                {
                    var dealId = e.SourceAppointment.CustomFields["Id"];
                    //-->
                    using (var db = new DealContext())
                    {
                        var deal = await db.Deals.FindAsync(dealId);
                        deal.VehicleId = vehicleId;
                        await db.SaveChangesAsync();
                    }
                    //<--
                }
                else
                {
                    var dealId = sourceDealId;
                    //-->
                    using (var db = new DealContext())
                    {
                        var deal = await db.Deals.FindAsync(dealId);
                        deal.VehicleId = vehicleId;
                        await db.SaveChangesAsync();
                    }
                    //<--
                }
                e.Allow = true;
                schedulerMain.BeginUpdate();
                RefreshData();
                schedulerMain.EndUpdate();
            }
            catch(Exception ex)
            {
                FredroMessageBox.ShowError($"Заявка не назначена: {ex.Message}");
                e.Allow = false;
            }
        }

        private void RefreshData()
        {
            storageMain.Appointments.DataSource = FredroHelper.GetAssignedDeals();
            gcFreeDeals.DataSource = FredroHelper.GetNotAssignedDeals();
        }

        private void groupControlMain_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if ("Назад".Equals(e.Button.Properties.Caption))
            {
                var svc = (IDateTimeNavigationService)schedulerMain.GetService(typeof(IDateTimeNavigationService));
                if (svc != null)
                {
                    svc.NavigateBackward();
                }
            }
            else if ("Вперёд".Equals(e.Button.Properties.Caption))
            {
                var svc = (IDateTimeNavigationService)schedulerMain.GetService(typeof(IDateTimeNavigationService));
                if (svc != null)
                {
                    svc.NavigateForward();
                }
            }
            else if ("На дату".Equals(e.Button.Properties.Caption))
            {
                schedulerMain.ShowGotoDateForm();
            }
            else if ("На сегодня".Equals(e.Button.Properties.Caption))
            {
                schedulerMain.GoToToday();
            }
        }

    }
}