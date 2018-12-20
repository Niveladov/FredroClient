using FredroClient.ExtraClasses;
using FredroClient.Models.DatabaseObjectModels.Tables;
using FredroClient.Models.DatabaseObjectModels.Tables.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class DealForeignsModel
    {
        public BindingList<Vehicle> Vehicles { get; }
        public BindingList<Customer> Customers { get; }
        public BindingList<Performer> Performers { get; }
        public BindingList<Dictionary_TripType> TripTypes { get; }

        public DealForeignsModel()
        {
            Vehicles = FredroHelper.GetAllVehicles();
            Customers = FredroHelper.GetAllCustomers();
            Performers = FredroHelper.GetAllPerformes();
            TripTypes = FredroHelper.GetAllTripTypes();
        }
    }
}
