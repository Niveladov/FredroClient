using TwinkleClient.ExtraClasses;
using TwinkleDAL.Models.DatabaseObjectModels.Tables;
using TwinkleDAL.Models.DatabaseObjectModels.Tables.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinkleClient.Models
{
    internal sealed class DealForeignsModel
    {
        public BindingList<Vehicle> Vehicles { get; }
        public BindingList<Customer> Customers { get; private set; }
        public BindingList<Performer> Performers { get; private set; }
        public BindingList<DictionaryTripType> TripTypes { get; }

        public DealForeignsModel()
        {
            Vehicles = TwinkleHelper.GetAllVehicles();
            Customers = TwinkleHelper.GetAllCustomers();
            Performers = TwinkleHelper.GetAllPerformes();
            TripTypes = TwinkleHelper.GetAllTripTypes();
        }

        public void RefreshPerformers()
        {
            Performers = TwinkleHelper.GetAllPerformes();
        }

        public void RefreshCustomers()
        {
            Customers = TwinkleHelper.GetAllCustomers();
        }


    }
}
