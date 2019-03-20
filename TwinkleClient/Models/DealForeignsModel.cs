using TwinkleClient.ExtraClasses;
using TwinkleDAL.Models.DatabaseObjectModels.Tables;
using TwinkleDAL.Models.DatabaseObjectModels.Tables.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinkleClient.BusinessObjectService;
using System.Collections.ObjectModel;

namespace TwinkleClient.Models
{
    internal sealed class DealForeignsModel
    {
        private readonly BusinessObjectServiceClient _boServiceClient;

        public ObservableCollection<Vehicle> Vehicles { get; }
        public ObservableCollection<Customer> Customers { get; private set; }
        public ObservableCollection<Performer> Performers { get; private set; }
        public ObservableCollection<DictionaryTripType> TripTypes { get; }

        public DealForeignsModel(BusinessObjectServiceClient boServiceClient)
        {
            _boServiceClient = boServiceClient;
            Vehicles = new ObservableCollection<Vehicle>(_boServiceClient.GetAllVehicles());
            Customers = new ObservableCollection<Customer>(_boServiceClient.GetAllCustomers());
            Performers = new ObservableCollection<Performer>(_boServiceClient.GetAllPerformers());
            TripTypes = new ObservableCollection<DictionaryTripType>(_boServiceClient.GetAllTripTypes());
        }

        public void RefreshPerformers()
        {
            Performers.Clear();
            foreach(var performer in _boServiceClient.GetAllPerformers())
            {
                Performers.Add(performer);
            }
        }

        public void RefreshCustomers()
        {
            Customers.Clear();
            foreach (var customer in _boServiceClient.GetAllCustomers())
            {
                Customers.Add(customer);
            }
        }


    }
}
