﻿using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraLayout.Utils;
using TwinklCRM.Client.BaseGUI;
using TwinklCRM.Client.ExtraClasses;
using TwinklCRM.Client.Models;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;
using System;
using System.Windows.Forms;
using TwinklCRM.Client.BusinessObjectService;
using System.ComponentModel;

namespace TwinklCRM.Client.Forms
{
    internal sealed partial class frmDeal : TwinkleBaseXtraForm
    {
        private readonly DealModel _dealModel;
        private readonly DealForeignsModel _loadingModel;
        private BusinessObjectServiceClient _boServiceClient;

        public frmDeal(BusinessObjectServiceClient boServiceClient)
        {
            InitializeComponent();
            _boServiceClient = boServiceClient;
            _dealModel = new DealModel(boServiceClient);
            _loadingModel = new DealForeignsModel(boServiceClient);
            InitControls();
            InitEvents();
            DisableControls();
        }

        public frmDeal(BusinessObjectServiceClient boServiceClient, Deal deal)
        {
            InitializeComponent();
            _dealModel = new DealModel(boServiceClient, deal);
            _loadingModel = new DealForeignsModel(boServiceClient);
            InitControls();
            InitEvents();
            SetReadonly(true);
            Text = "Просмотр заявки(сделки)";
        }

        private void InitEvents()
        {
            description.TextChanged += MemoEdit_TextChanged;
            route.TextChanged += MemoEdit_TextChanged;
            customer.Properties.ButtonClick += Customer_CustomButtonClick;
            performer.Properties.ButtonClick += Performer_CustomButtonClick;

            _dealModel.CurrentDeal.PropertyChanged += OnDealPropertyChanged;
        }

        private void InitControls()
        {
            start.DataBindings.Add(new Binding("EditValue", _dealModel.CurrentDeal, nameof(_dealModel.CurrentDeal.DateStart),
                true, DataSourceUpdateMode.OnPropertyChanged));
            end.DataBindings.Add(new Binding("EditValue", _dealModel.CurrentDeal, nameof(_dealModel.CurrentDeal.DateEnd),
                true, DataSourceUpdateMode.OnPropertyChanged));
            route.DataBindings.Add(new Binding("EditValue", _dealModel.CurrentDeal, nameof(_dealModel.CurrentDeal.Route),
                true, DataSourceUpdateMode.OnPropertyChanged));
            description.DataBindings.Add(new Binding("EditValue", _dealModel.CurrentDeal, nameof(_dealModel.CurrentDeal.Description),
                true, DataSourceUpdateMode.OnPropertyChanged));

            customer.Properties.DataSource = _loadingModel.Customers;
            customer.Properties.DisplayMember = nameof(Customer.SubjectName);
            customer.Properties.ValueMember = nameof(Customer.Id);
            customer.Properties.PopulateViewColumns();
            customer.Properties.View.Columns[nameof(Customer.Id)].Visible = false;
            customer.Properties.View.Columns[nameof(Customer.IsDel)].Visible = false;
            customer.Properties.View.Columns[nameof(Customer.CreatedBy)].Visible = false;
            customer.Properties.View.Columns[nameof(Customer.CreationDate)].Visible = false;
            customer.DataBindings.Add(new Binding("EditValue", _dealModel.CurrentDeal, nameof(_dealModel.CurrentDeal.CustomerId),
                true, DataSourceUpdateMode.OnPropertyChanged));

            performer.Properties.DataSource = _loadingModel.Performers;
            performer.Properties.DisplayMember = nameof(Performer.SubjectName);
            performer.Properties.ValueMember = nameof(Performer.Id);
            performer.Properties.PopulateViewColumns();
            performer.Properties.View.Columns[nameof(Performer.Id)].Visible = false;
            performer.Properties.View.Columns[nameof(Performer.IsDel)].Visible = false;
            performer.Properties.View.Columns[nameof(Performer.CreatedBy)].Visible = false;
            performer.Properties.View.Columns[nameof(Performer.CreationDate)].Visible = false;
            performer.DataBindings.Add(new Binding("EditValue", _dealModel.CurrentDeal, nameof(_dealModel.CurrentDeal.PerformerId),
                true, DataSourceUpdateMode.OnPropertyChanged));

            vehicle.Properties.DataSource = _loadingModel.Vehicles;
            vehicle.Properties.DisplayMember = nameof(Vehicle.Name);
            vehicle.Properties.ValueMember = nameof(Vehicle.Id);
            vehicle.Properties.PopulateViewColumns();
            vehicle.Properties.View.Columns[nameof(Vehicle.Id)].Visible = false;
            vehicle.Properties.View.Columns[nameof(Vehicle.IsDel)].Visible = false;
            vehicle.Properties.View.Columns[nameof(Vehicle.CreatedBy)].Visible = false;
            vehicle.Properties.View.Columns[nameof(Vehicle.CreationDate)].Visible = false;
            vehicle.DataBindings.Add(new Binding("EditValue", _dealModel.CurrentDeal, nameof(_dealModel.CurrentDeal.VehicleId),
                true, DataSourceUpdateMode.OnPropertyChanged));

            tripType.Properties.DataSource = _loadingModel.TripTypes;
            tripType.Properties.DisplayMember = nameof(DictionaryTripType.Name);
            tripType.Properties.ValueMember = nameof(DictionaryTripType.Id);
            tripType.Properties.PopulateViewColumns();
            tripType.Properties.View.Columns[nameof(DictionaryTripType.Id)].Visible = false;
            tripType.Properties.View.Columns[nameof(DictionaryTripType.IsDel)].Visible = false;
            tripType.Properties.View.Columns[nameof(DictionaryTripType.CreatedBy)].Visible = false;
            tripType.Properties.View.Columns[nameof(DictionaryTripType.CreationDate)].Visible = false;
            tripType.DataBindings.Add(new Binding("EditValue", _dealModel.CurrentDeal, nameof(_dealModel.CurrentDeal.TripTypeId),
                true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void DisableControls()
        {
            vehicle.Enabled = false;
        }

        private void SetReadonly(bool isReadOnly)
        {
            start.Properties.ReadOnly = isReadOnly;
            end.Properties.ReadOnly = isReadOnly;
            route.Properties.ReadOnly = isReadOnly;
            description.Properties.ReadOnly = isReadOnly;
            customer.Properties.ReadOnly = isReadOnly;
            performer.Properties.ReadOnly = isReadOnly;
            vehicle.Properties.ReadOnly = isReadOnly;
            tripType.Properties.ReadOnly = isReadOnly;

            start.Properties.AllowFocused = !isReadOnly;
            end.Properties.AllowFocused = !isReadOnly;
            route.Properties.AllowFocused = !isReadOnly;
            description.Properties.AllowFocused = !isReadOnly;
            customer.Properties.AllowFocused = !isReadOnly;
            performer.Properties.AllowFocused = !isReadOnly;
            vehicle.Properties.AllowFocused = !isReadOnly;
            tripType.Properties.AllowFocused = !isReadOnly;

            lciSave.Visibility = isReadOnly ? LayoutVisibility.Never : LayoutVisibility.Always;
        }

        private void DisableBtnSave()
        {
            btnSave.Enabled = false;
        }

        private void EnableBtnSave()
        {
            btnSave.Enabled = true;
        }

        private void MemoEdit_TextChanged(object sender, EventArgs e)
        {
            var memoEdit = sender as MemoEdit;
            if (memoEdit != null) memoEdit.SetScrollBarVisibility();
        }

        private void OnDealPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Deal.DateStart) && _dealModel.CurrentDeal.DateStart.HasValue && _dealModel.CurrentDeal.DateEnd.HasValue)
            {
                if (_dealModel.CurrentDeal.DateStart.Value > _dealModel.CurrentDeal.DateEnd.Value)
                {
                    start.ErrorText = "Дата начала сделки должна быть меньше даты окончания!";
                    DisableBtnSave();
                }
                else
                {
                    start.ErrorText = string.Empty;
                    EnableBtnSave();
                }
            }
            else if (e.PropertyName == nameof(Deal.DateEnd) && _dealModel.CurrentDeal.DateStart.HasValue && _dealModel.CurrentDeal.DateEnd.HasValue)
            {
                if (_dealModel.CurrentDeal.DateStart.Value > _dealModel.CurrentDeal.DateEnd.Value)
                {
                    end.ErrorText = "Дата окончания сделки должна быть больше даты начала!";
                    DisableBtnSave();
                }
                else
                {
                    end.ErrorText = string.Empty;
                    EnableBtnSave();
                }
            }
        }

        private void Performer_CustomButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                using (var frm = new frmPerformer(_boServiceClient))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        _loadingModel.RefreshPerformers();
                        //performer.Properties.DataSource = _loadingModel.Performers;
                    }
                }
            }
        }

        private void Customer_CustomButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                using (var frm = new frmCustomer(_boServiceClient))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        _loadingModel.RefreshCustomers();
                        //customer.Properties.DataSource = _loadingModel.Customers;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        //ToDo: to add async
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _dealModel.Save();
                TwinkleMessageBox.ShowSucces("Заяка(сделка) успешно сохранена!");
                Close();
            }
            catch (Exception ex)
            {
                TwinkleMessageBox.ShowError($"Заяка(сделка) не сохранена! {ex.Message}");
            }
        }


    }
}
