using DevExpress.XtraScheduler;
using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.Models;
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
        public frmSchedule()
        {
            InitializeComponent();
            InitData();
        }

        private void FrmSchedule_Load(object sender, EventArgs e)
        {
            schedulerMain.Start = DateTime.Today;
            schedulerMain.TimelineView.Scales[4].Width = schedulerMain.Bounds.Width;
            schedulerMain.TimelineView.Scales[5].Width = schedulerMain.Bounds.Width / 25;
            schedulerMain.ActiveView.LayoutChanged();
        }

        public void InitData()
        {
            storageMain.Resources.DataSource = FredroHelper.GetAllViewVehicles();
            storageMain.Resources.Mappings.Id = nameof(ViewVehicle.Id);
            storageMain.Resources.Mappings.Caption = nameof(ViewVehicle.Name);
            storageMain.Resources.Mappings.ParentId = nameof(ViewVehicle.ParentId);

            storageMain.Appointments.DataSource = FredroHelper.GetAllDeals();
            storageMain.Appointments.Mappings.AppointmentId = nameof(Deal.Id);
            storageMain.Appointments.Mappings.ResourceId = nameof(Deal.TransportId);
            storageMain.Appointments.Mappings.Subject = nameof(Deal.Route);
            storageMain.Appointments.Mappings.Start = nameof(Deal.DateStart);
            storageMain.Appointments.Mappings.End = nameof(Deal.DateEnd);
            storageMain.Appointments.Mappings.Description = nameof(Deal.Description);
            storageMain.Appointments.Mappings.Status = nameof(Deal.DealStatusId);
            
        }

        private void groupControlMain_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if ("Назад".Equals(e.Button.Properties.Caption))
            {

            }
            else if ("Вперёд".Equals(e.Button.Properties.Caption))
            {

            }
            else if ("На дату".Equals(e.Button.Properties.Caption))
            {

            }
        }

    }
}
