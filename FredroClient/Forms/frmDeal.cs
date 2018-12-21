using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.Models;
using FredroClient.Models.DatabaseObjectModels.Tables;
using FredroClient.Models.DatabaseObjectModels.Tables.Dictionaries;
using FredroClient.Models.DatabaseObjectModels.Views;
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
    internal sealed partial class frmDeal : FredroBaseXtraForm
    {
        private readonly DealModel _dealModel;
        private readonly DealForeignsModel _loadingModel;

        public frmDeal()
        {
            InitializeComponent();
            _dealModel = new DealModel();
            _loadingModel = new DealForeignsModel();
            InitControls();
            InitEvents();
        }

        public frmDeal(Deal deal)
        {
            InitializeComponent();
            _dealModel = new DealModel(deal);
            _loadingModel = new DealForeignsModel();
            InitControls();
            InitEvents();
        }

        private void InitEvents()
        {
            description.TextChanged += MemoEdit_TextChanged;
            route.TextChanged += MemoEdit_TextChanged;
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

        private void SetFormReadonly()
        {

        }

        private void MemoEdit_TextChanged(object sender, EventArgs e)
        {
            var memoEdit = sender as MemoEdit;
            if (memoEdit != null) memoEdit.SetScrollBarVisibility();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                await _dealModel.Save();
                FredroMessageBox.ShowSucces("Заяка(сделка) успешно сохранена!");
                Close();
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError($"Заяка(сделка) не сохранена! {ex.Message}");
            }
        }


    }
}
