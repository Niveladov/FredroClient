using FredroClient.ExtraClasses;
using FredroClient.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class NewDealForeignsModel
    {
        public BindingList<Vehicle> Vehicles { get; }
        public BindingList<Customer> Customers { get; }
        public BindingList<Performer> Performers { get; }

        public NewDealForeignsModel()
        {
            Vehicles = FredroHelper.GetAllVehicles();
            Customers = FredroHelper.GetAllCustomers();
            Performers = FredroHelper.GetAllPerformes();
        }
    }
}
