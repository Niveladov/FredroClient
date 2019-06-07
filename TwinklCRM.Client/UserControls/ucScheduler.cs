using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinklCRM.Client.ExtraClasses;
using TwinklCRM.Client.Models;
using DevExpress.XtraScheduler;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.Services;
using TwinklCRM.Client.BaseGUI;
using DevExpress.Utils;
using DevExpress.XtraScheduler.Drawing;
using TwinklCRM.Client.Forms;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Views;
using TwinklCRM.DAL.Models.Contexts;
using DevExpress.XtraEditors.ButtonPanel;
using TwinklCRM.Client.BusinessObjectService;
using System.ServiceModel;
using TwinklCRM.Client.SchedulerService;

namespace TwinklCRM.Client.UserControls
{
    public partial class ucScheduler : ucBase, ISchedulerServiceCallback
    {
        private readonly WaitingHelper _waitingHelper;
        private GridHitInfo _downHitInfo;
        private Deal _popupDeal;
        private SchedulerModel _model;

        public ucScheduler()
        {
            InitializeComponent();
            _waitingHelper = new WaitingHelper(ParentForm);
        }

        private void UcScheduler_Load(object sender, EventArgs e)
        {
            if (!isDesignMode)
            {
                _waitingHelper.Show();
                InitHeaderButtons();
                InitSchedulerDesigner();
                Join();
                InitSchedulers();
                InitGrids();
                InitEvents();
                _waitingHelper.Hide();
            }
        }

        private void InitHeaderButtons()
        {
            groupControlMain.CustomHeaderButtons.Where(x =>
                x.Properties.Caption.Equals("Уменьшить")).Single().Properties.Enabled = false;
        }

        private void InitSchedulerDesigner()
        {
            schedulerMain.Start = DateTime.Today;
            schedulerMain.TimelineView.Scales[4].Width = schedulerMain.Bounds.Width;
            schedulerMain.TimelineView.Scales[5].Width = schedulerMain.Bounds.Width / 24;
            schedulerMain.TimelineView.Scales[7].Width = schedulerMain.TimelineView.Scales[5].Width / 2;
            schedulerMain.TimelineView.WorkTime = new TimeOfDayInterval(new TimeSpan(6, 0, 0), new TimeSpan(23, 59, 59));
            schedulerMain.ActiveView.LayoutChanged();
        }
        
        //  summary:
        //      initialize uc models
        public void Init(BusinessObjectServiceClient boServiceClient)
        {
            var instanceContext = new InstanceContext(this);
            _model = new SchedulerModel(boServiceClient, instanceContext);
        }

        //  summary:
        //      connect to the service
        //      and subscribe to reloading data 
        private void Join()
        {
            _model.JoinToServer();
        }
        
        public void CloseConnection()
        {
            _model.CloseServerConnection();
        }

        private void InitEvents()
        {
            resourcesTreeMain.CustomDrawNodeCell += ResourcesTreeMain_CustomDrawNodeCell;

            gvFreeDeals.MouseDown += GvFreeDeals_MouseDown;
            gvFreeDeals.MouseMove += GvFreeDeals_MouseMove;

            schedulerMain.AppointmentDrop += SchedulerMain_AppointmentDrop;
            schedulerMain.AllowAppointmentConflicts += ScchedulerMain_AllowAppointmentConflicts;
            schedulerMain.AppointmentViewInfoCustomizing += SchedulerMain_AppointmentViewInfoCustomizing;
            schedulerMain.PopupMenuShowing += SchedulerMain_PopupMenuShowing;
            //schedulerMain.SelectionChanged += SchedulerMain_SelectionChanged;
            schedulerMain.EditAppointmentFormShowing += SchedulerMain_EditAppointmentFormShowing;

            groupControlMain.CustomButtonClick += GroupControlMain_CustomButtonClick;

            toolTipController.BeforeShow += ToolTipController_BeforeShow;
        }

        private void InitSchedulers()
        {
            storageMain.Resources.DataSource = _model.Resources;
            storageMain.Resources.Mappings.Id = nameof(ViewVehicle.Id);
            storageMain.Resources.Mappings.Caption = nameof(ViewVehicle.Name);
            storageMain.Resources.Mappings.ParentId = nameof(ViewVehicle.ParentId);
            storageMain.Resources.Mappings.ParentId = nameof(ViewVehicle.Color);

            storageMain.Appointments.DataSource = _model.AssignedAppointments;
            storageMain.Appointments.Mappings.AppointmentId = nameof(ViewAssignedDeal.Id);
            storageMain.Appointments.Mappings.ResourceId = nameof(ViewAssignedDeal.VehicleId);
            storageMain.Appointments.Mappings.Subject = nameof(ViewAssignedDeal.Route);
            storageMain.Appointments.Mappings.Start = nameof(ViewAssignedDeal.DateStart);
            storageMain.Appointments.Mappings.End = nameof(ViewAssignedDeal.DateEnd);
            storageMain.Appointments.Mappings.Description = nameof(ViewAssignedDeal.Description);
            storageMain.Appointments.Mappings.Status = nameof(ViewAssignedDeal.DealStatusId);

            storageMain.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("Id", nameof(Deal.Id)));
            storageMain.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("PassengersCount", nameof(ViewAssignedDeal.PassengersCount)));
            storageMain.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("TripTypeName", nameof(ViewAssignedDeal.TripTypeName)));
        }

        private void InitGrids()
        {
            gcFreeDeals.DataSource = _model.FreeAppointments;
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

        private void ShowDealForm(Deal deal)
        {
            if (deal == null)
            {
                TwinkleMessageBox.ShowError("Зделка не может быть null");
                return;
            }
            else
            {
                using (var frm = new frmDeal(_model.BOServiceClient, deal))
                {
                    frm.ShowDialog();
                }
            }
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

        private void SchedulerMain_AppointmentDrop(object sender, AppointmentDragEventArgs e)
        {
            try
            {
                if (e.EditedAppointment.ResourceId is EmptyResource || Convert.ToInt32(e.EditedAppointment.ResourceId) <= 0)
                {
                    TwinkleMessageBox.ShowError("Заяка не будет назначена: выбран пустой ресурс(ТС)");
                    e.Allow = false;
                    return;
                }
                var start = e.SourceAppointment.Start;
                if (start <= DateTime.Now)
                {
                    TwinkleMessageBox.ShowError("Заяка не будет назначена: невозможно назначить заяку на прошедшее время");
                    e.Allow = false;
                    return;
                }
                var end = e.SourceAppointment.End;
                var vehicleId = Convert.ToInt32(e.EditedAppointment.ResourceId);
                if (CheckIfResourceIsBusy(vehicleId, start, end))
                {
                    TwinkleMessageBox.ShowError("Заяка не будет назначена: выбранный ресурс(ТС) занят");
                    e.Allow = false;
                    return;
                }
                var sourceDealId = e.SourceAppointment.Id;
                if (sourceDealId == null)
                {
                    var dealId = e.SourceAppointment.CustomFields["Id"];
                    _model.AssignAppointment((int)dealId, vehicleId);
                    //-->
                    //using (var db = new TwinkleDbContext())
                    //{
                    //    deal = await db.Deals.FindAsync(dealId);
                    //    deal.VehicleId = vehicleId;
                    //    await db.SaveChangesAsync();
                    //}
                    //<--
                }
                else
                {
                    var dealId = sourceDealId;
                    _model.AssignAppointment((int)dealId, vehicleId);
                    //-->
                    //using (var db = new TwinkleDbContext())
                    //{
                    //    deal = await db.Deals.FindAsync(dealId);
                    //    deal.VehicleId = vehicleId;
                    //    await db.SaveChangesAsync();
                    //}
                    //<--
                }
                e.Allow = true;
                schedulerMain.BeginUpdate();
                schedulerMain.GoToDate(start.Date.AddHours(schedulerMain.Start.Hour));
                //RefreshAppointments();
                schedulerMain.EndUpdate();
            }
            catch (Exception ex)
            {
                TwinkleMessageBox.ShowError($"Заявка не назначена: {ex.Message}");
                e.Allow = false;
            }
        }

        private void RefreshAppointments()
        {
            storageMain.Appointments.DataSource = _model.AssignedAppointments;
            gcFreeDeals.DataSource = _model.FreeAppointments;
        }

        private void GroupControlMain_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "Назад":
                    BtnBackwardAction();
                    break;
                case "Вперёд":
                    BtnForwardAction();
                    break;
                case "На дату":
                    BtnGoToDateAction();
                    break;
                case "На сегодня":
                    BtnGoToTodayAction();
                    break;
                case "Увеличить":
                    BtnZoomInAction(e.Button);
                    break;
                case "Уменьшить":
                    BtnZoomOutAction(e.Button);
                    break;
                case "Поиск":
                    BtnSearchAction(e.Button);
                    break;
                case "Обновить":
                    BtnRefreshAction();
                    break;
                default:
                    break;
            }
        }

        private void BtnRefreshAction()
        {
            RefreshAppointments();
        }

        private void BtnSearchAction(IBaseButton button)
        {
            switch (button.Properties.ToolTip)
            {
                case "Скрыть поиск":
                    BtnHideSearchAction(button);
                    break;
                case "Показать поиск":
                    BtnShowSearchAction(button);
                    break;
            }
        }

        private void BtnShowSearchAction(IBaseButton button)
        {
            button.Properties.ToolTip = "Скрыть поиск";
            button.Properties.Image = Properties.Resources.search_32x32;
            gvFreeDeals.OptionsFind.AlwaysVisible = true;
        }

        private void BtnHideSearchAction(IBaseButton button)
        {
            button.Properties.ToolTip = "Показать поиск";
            button.Properties.Image = Properties.Resources.search_pink_32x32;
            gvFreeDeals.OptionsFind.AlwaysVisible = false;
        }

        private void BtnZoomOutAction(IBaseButton button)
        {
            schedulerMain.TimelineView.Scales[5].Width = schedulerMain.Bounds.Width / 24;
            schedulerMain.TimelineView.Scales[7].Width = schedulerMain.TimelineView.Scales[5].Width / 2;
            schedulerMain.GoToDate(schedulerMain.Start.Date);
            schedulerMain.ActiveView.LayoutChanged();
            var buttomPlus = groupControlMain.CustomHeaderButtons.Where(x => x.Properties.Caption.Equals("Увеличить")).Single();
            buttomPlus.Properties.Enabled = true;
            button.Properties.Enabled = false;
        }

        private void BtnZoomInAction(IBaseButton button)
        {
            schedulerMain.TimelineView.Scales[5].Width = schedulerMain.Bounds.Width / 18;
            schedulerMain.TimelineView.Scales[7].Width = schedulerMain.TimelineView.Scales[5].Width / 2;
            schedulerMain.GoToDate(schedulerMain.Start.Date.AddHours(6));
            schedulerMain.ActiveView.LayoutChanged();
            var buttonMinus = groupControlMain.CustomHeaderButtons.Where(x => x.Properties.Caption.Equals("Уменьшить")).Single();
            buttonMinus.Properties.Enabled = true;
            button.Properties.Enabled = false;
        }

        private void BtnGoToTodayAction()
        {
            schedulerMain.GoToToday();
        }

        private void BtnGoToDateAction()
        {
            schedulerMain.ShowGotoDateForm();
        }

        private void BtnForwardAction()
        {
            schedulerMain.GoToDate(schedulerMain.Start.AddDays(1));
        }

        private void BtnBackwardAction()
        {
            schedulerMain.GoToDate(schedulerMain.Start.AddDays(-1));
        }

        //private void SchedulerMain_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (schedulerMain.SelectedAppointments.Count > 0)
        //    {
        //        var focusedAppointment = schedulerMain.SelectedAppointments.First();
        //        var focusedAppointmentId = (int)focusedAppointment.Id;
        //        var focusedDeal = FredroHelper.GetDeal(focusedAppointmentId);
        //        if (focusedDeal.Id.HasValue)
        //        {
        //            //schedulerMain.BeginUpdate();
        //            //schedulerMain.BeginUpdate();

        //            _focusedDeal = focusedDeal;

        //            //schedulerMain.EndUpdate();
        //            //schedulerMain.EndUpdate();
        //        }

        //    }
        //}

        private void SchedulerMain_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            e.Handled = true;
            var editedAppointmentId = (int)e.Appointment.Id;
            //ToDo: to remake
            var editedDeal = _model.GetDeal(editedAppointmentId); //TwinkleHelper.GetDeal(editedAppointmentId);
            ShowDealForm(editedDeal);
        }

        private void SchedulerMain_PopupMenuShowing(object sender, DevExpress.XtraScheduler.PopupMenuShowingEventArgs e)
        {
            e.Menu.Items.Clear();
            if (e.Menu.Id == SchedulerMenuItemId.AppointmentMenu)
            {
                var popupAppointment = schedulerMain.SelectedAppointments.Single();
                var popupAppointmentId = (int)popupAppointment.Id;
                _popupDeal = _model.GetDeal(popupAppointmentId); //TwinkleHelper.GetDeal(popupAppointmentId);

                var openItem = new SchedulerMenuItem("Просмотр", OnOpenItemClick, Properties.Resources.view_16x16);
                e.Menu.Items.Add(openItem);
            }
        }

        private void OnOpenItemClick(object sender, EventArgs e)
        {
            ShowDealForm(_popupDeal);
        }

        #region Appearance

        private void ResourcesTreeMain_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            if (schedulerMain.Storage != null)
            {
                object resourceId = e.Node.GetValue("Id");
                Resource resource = storageMain.Resources.GetResourceById(resourceId);
                if (resource != null && e.Column.FieldName == nameof(ViewVehicle.PassengersCount))
                {
                    e.Appearance.BackColor = resource.Color;
                }
            }
        }

        private void ToolTipController_BeforeShow(object sender, ToolTipControllerShowEventArgs e)
        {
            ToolTipController controller = sender as ToolTipController;
            AppointmentViewInfo aptViewInfo = controller.ActiveObject as AppointmentViewInfo;
            if (aptViewInfo == null) return;

            if (toolTipController.ToolTipType == ToolTipType.SuperTip)
            {
                var selectedObject = e.SelectedObject as TimeLineAppointmentViewInfo;
                var appointment = selectedObject.Appointment;

                SuperToolTip SuperTip = new SuperToolTip();
                SuperToolTipSetupArgs args = new SuperToolTipSetupArgs();
                var font = new Font("Tahoma", 10);
                args.Title.Text = appointment.Start.ToString("g") + " - " + appointment.End.ToString("g");
                args.Title.Font = font;
                args.Contents.Text = aptViewInfo.DisplayText + Environment.NewLine + aptViewInfo.Description + Environment.NewLine + "Кол-во:" + appointment.CustomFields["PassengersCount"]?.ToString();
                args.Contents.Font = font;
                args.Contents.Image = Properties.Resources.info_32x32;
                args.ShowFooterSeparator = true;
                args.Footer.Font = font;
                args.Footer.Text = appointment.CustomFields["TripTypeName"]?.ToString();
                SuperTip.Setup(args);
                e.SuperTip = SuperTip;
            }
        }

        private void SchedulerMain_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
        {
            //if (e.ViewInfo.DisplayText == String.Empty)
            //e.ViewInfo.ToolTipText = String.Format("Started at {0:g}", e.ViewInfo.Appointment.Start);
        }

        #endregion

        #region Service Callback

        public void SendAssignedAppointments(ViewAssignedDeal[] assignedAppointments)
        {
            schedulerMain.Storage.BeginUpdate();
            _model.LoadAssignedAppointments(assignedAppointments);
            schedulerMain.Storage.EndUpdate();
        }

        public void SendFreeAppointments(Deal[] freeAppointments)
        {
            schedulerMain.Storage.BeginUpdate();
            _model.LoadFreeAppointments(freeAppointments);
            schedulerMain.Storage.EndUpdate();
        }

        #endregion

    }
}
