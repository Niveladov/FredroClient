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
            customer.DataBindings.Add(new Binding("EditValue", _dealModel.NewDeal, nameof(_dealModel.NewDeal.CustomerId),
                true, DataSourceUpdateMode.OnPropertyChanged));

            performer.Properties.DataSource = _loadingModel.Performers;
            performer.Properties.DisplayMember = nameof(Performer.SubjectName);
            performer.Properties.ValueMember = nameof(Performer.Id);
            performer.DataBindings.Add(new Binding("EditValue", _dealModel.NewDeal, nameof(_dealModel.NewDeal.PerformerId),
                true, DataSourceUpdateMode.OnPropertyChanged));

            vehicle.Properties.DataSource = _loadingModel.Vehicles;
            vehicle.Properties.DisplayMember = nameof(Vehicle.Name);
            vehicle.Properties.ValueMember = nameof(Vehicle.Id);
            vehicle.DataBindings.Add(new Binding("EditValue", _dealModel.NewDeal, nameof(_dealModel.NewDeal.TransportId),
                true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _dealModel.Save();
        }


    }
}
