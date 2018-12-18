using DevExpress.XtraEditors;
using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.Models;
using FredroClient.Models.DatabaseObjectModels.Tables;
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
    internal sealed partial class frmNewDeal : FredroBaseXtraForm
    {
        private readonly NewDealModel _dealModel;
        private readonly NewDealForeignsModel _loadingModel;

        public frmNewDeal()
        {
            InitializeComponent();
            _dealModel = new NewDealModel();
            _loadingModel = new NewDealForeignsModel();
            InitControls();
        }

        private void InitControls()
        {
            start.DataBindings.Add(new Binding("EditValue", _dealModel.NewDeal, nameof(_dealModel.NewDeal.DateStart),
                true, DataSourceUpdateMode.OnPropertyChanged));
            end.DataBindings.Add(new Binding("EditValue", _dealModel.NewDeal, nameof(_dealModel.NewDeal.DateEnd),
                true, DataSourceUpdateMode.OnPropertyChanged));
            route.DataBindings.Add(new Binding("EditValue", _dealModel.NewDeal, nameof(_dealModel.NewDeal.Route),
                true, DataSourceUpdateMode.OnPropertyChanged));
            description.DataBindings.Add(new Binding("EditValue", _dealModel.NewDeal, nameof(_dealModel.NewDeal.Description),
                true, DataSourceUpdateMode.OnPropertyChanged));

            customer.Properties.DataSource = _loadingModel.Customers;
            customer.Properties.DisplayMember = nameof(Customer.SubjectName);
            customer.Properties.ValueMember = nameof(Customer.Id);
            customer.Properties.PopulateViewColumns();
            customer.Properties.View.Columns[nameof(Customer.Id)].Visible = false;
            customer.Properties.View.Columns[nameof(Customer.IsDel)].Visible = false;
            customer.Properties.View.Columns[nameof(Customer.CreatedBy)].Visible = false;
            customer.Properties.View.Columns[nameof(Customer.CreationDate)].Visible = false;
            customer.DataBindings.Add(new Binding("EditValue", _dealModel.NewDeal, nameof(_dealModel.NewDeal.CustomerId),
                true, DataSourceUpdateMode.OnPropertyChanged));

            performer.Properties.DataSource = _loadingModel.Performers;
            performer.Properties.DisplayMember = nameof(Performer.SubjectName);
            performer.Properties.ValueMember = nameof(Performer.Id);
            performer.Properties.PopulateViewColumns();
            performer.Properties.View.Columns[nameof(Performer.Id)].Visible = false;
            performer.Properties.View.Columns[nameof(Performer.IsDel)].Visible = false;
            performer.Properties.View.Columns[nameof(Performer.CreatedBy)].Visible = false;
            performer.Properties.View.Columns[nameof(Performer.CreationDate)].Visible = false;
            performer.DataBindings.Add(new Binding("EditValue", _dealModel.NewDeal, nameof(_dealModel.NewDeal.PerformerId),
                true, DataSourceUpdateMode.OnPropertyChanged));

            vehicle.Properties.DataSource = _loadingModel.Vehicles;
            vehicle.Properties.DisplayMember = nameof(Vehicle.Name);
            vehicle.Properties.ValueMember = nameof(Vehicle.Id);
            vehicle.Properties.PopulateViewColumns();
            vehicle.Properties.View.Columns[nameof(Vehicle.Id)].Visible = false;
            //vehicle.Properties.View.Columns[nameof(Vehicle.IsDel)].Visible = false;
            //vehicle.Properties.View.Columns[nameof(Vehicle.CreatedBy)].Visible = false;
            //vehicle.Properties.View.Columns[nameof(Vehicle.CreationDate)].Visible = false;
            vehicle.DataBindings.Add(new Binding("EditValue", _dealModel.NewDeal, nameof(_dealModel.NewDeal.VehicleId),
                true, DataSourceUpdateMode.OnPropertyChanged));
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
