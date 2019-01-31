using FredroClient.ExtraClasses;
using FredroDAL.Models.DatabaseObjectModels.Tables;
using FredroDAL.Models.DatabaseObjectModels.Tables.Dictionaries;
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
        public BindingList<Customer> Customers { get; private set; }
        public BindingList<Performer> Performers { get; private set; }
        public BindingList<DictionaryTripType> TripTypes { get; }

        public DealForeignsModel()
        {
            Vehicles = FredroHelper.GetAllVehicles();
            Customers = FredroHelper.GetAllCustomers();
            Performers = FredroHelper.GetAllPerformes();
            TripTypes = FredroHelper.GetAllTripTypes();
        }

        public void RefreshPerformers()
        {
            Performers = FredroHelper.GetAllPerformes();
        }

        public void RefreshCustomers()
        {
            Customers = FredroHelper.GetAllCustomers();
        }


    }
}
