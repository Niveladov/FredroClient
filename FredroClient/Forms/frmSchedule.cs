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

        public void InitData()
        {
            resourcesTreeMain.SchedulerControl = schedulerMain;

            storageMain.Resources.DataSource = FredroHelper.GetAllVehicles();
            storageMain.Resources.Mappings.Id = nameof(Vehicle.Id);
            storageMain.Resources.Mappings.Caption = nameof(Vehicle.Name);

            storageMain.Appointments.DataSource = FredroHelper.GetAllDeals();
            storageMain.Appointments.Mappings.AppointmentId = nameof(Deal.Id);
            storageMain.Appointments.Mappings.Subject = nameof(Deal.Route);
            storageMain.Appointments.Mappings.Start = nameof(Deal.DateStart);
            storageMain.Appointments.Mappings.End = nameof(Deal.DateEnd);
            storageMain.Appointments.Mappings.Description = nameof(Deal.Description);
            storageMain.Appointments.Mappings.Status = nameof(Deal.DealStatusId);
            
        }

    }
}
