using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces;
using TwinklCRM.DAL.Models.Contexts;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models
{
    internal sealed class DbDataManager : IDbDataManager
    {
        public void DeleteDeal(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                var deal = db.Deals.Find(id);
                db.Deals.Remove(deal);
                db.SaveChanges();
            }
        }

        public void DeletePerformer(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                var performer = db.Performers.Find(id);
                db.Performers.Remove(performer);
                db.SaveChanges();
            }
        }

        public void DeleteCustomer(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                var customer = db.Customers.Find(id);
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            using (var db = new TwinkleDbContext())
            {
                db.Customers.Load();
                return db.Customers.ToList();
            }
        }

        public IEnumerable<Performer> GetAllPerformers()
        {
            using (var db = new TwinkleDbContext())
            {
                db.Performers.Load();
                return db.Performers.ToList();
            }
        }

        public IEnumerable<DictionaryTripType> GetAllTripTypes()
        {
            using (var db = new TwinkleDbContext())
            {
                db.TripTypes.Load();
                return db.TripTypes.ToList();
            }
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            using (var db = new TwinkleDbContext())
            {
                db.Vehicles.Load();
                return db.Vehicles.ToList();
            }
        }

        public Deal GetDeal(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.Deals.Find(id);
            }
        }

        public Performer GetPerformer(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.Performers.Find(id);
            }
        }

        public Customer GetCustomer(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.Customers.Find(id);
            }
        }

        public void InsertDeal(Deal deal)
        {
            using (var db = new TwinkleDbContext())
            {
                deal.CreatedBy = -1;
                deal.CreationDate = DateTime.Now;
                db.Deals.Add(deal);
                db.SaveChanges();
            }
        }

        public void InsertPerformer(Performer performer)
        {
            using (var db = new TwinkleDbContext())
            {
                performer.CreatedBy = -1;
                performer.CreationDate = DateTime.Now;
                db.Performers.Add(performer);
                db.SaveChanges();
            }
        }

        public void InsertCustomer(Customer customer)
        {
            using (var db = new TwinkleDbContext())
            {
                customer.CreatedBy = -1;
                customer.CreationDate = DateTime.Now;
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public void UpdateDeal(Deal deal)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerformer(Performer performer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DictionaryVehicleType> GetAllVehicleTypes()
        {
            using (var db = new TwinkleDbContext())
            {
                db.VehicleTypes.Load();
                return db.VehicleTypes.ToList();
            }
        }

        public IEnumerable<DictionaryEmailFolderType> GetAllEmailFolderTypes()
        {
            using (var db = new TwinkleDbContext())
            {
                db.EmailFolderTypes.Load();
                return db.EmailFolderTypes.ToList();
            }
        }

        public IEnumerable<DictionaryEmailServer> GetAllEmailServers()
        {
            using (var db = new TwinkleDbContext())
            {
                db.EmailServers.Load();
                return db.EmailServers.ToList();
            }
        }

        public IEnumerable<DictionaryEmailServerParam> GetAllEmailServerParams()
        {
            using (var db = new TwinkleDbContext())
            {
                db.EmailServerParams.Load();
                return db.EmailServerParams.ToList();
            }
        }

        public IEnumerable<DictionaryHierarchy> GetAllHierarchies()
        {
            using (var db = new TwinkleDbContext())
            {
                db.Hierarchies.Load();
                return db.Hierarchies.ToList();
            }
        }

        public IEnumerable<Deal> GetAllDeals()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicle(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicle(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void InsertVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public DictionaryTripType GetTripType(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteTripType(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTripType(DictionaryTripType tripType)
        {
            throw new NotImplementedException();
        }

        public void InsertTripType(DictionaryTripType tripType)
        {
            throw new NotImplementedException();
        }

        public DictionaryVehicleType GetVehicleType(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicleType(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicleType(DictionaryVehicleType vehicleType)
        {
            throw new NotImplementedException();
        }

        public void InsertVehicleType(DictionaryVehicleType vehicleType)
        {
            throw new NotImplementedException();
        }

        public DictionaryEmailFolderType GetEmailFolderType(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmailFolderType(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmailFolderType(DictionaryEmailFolderType emailFolderType)
        {
            throw new NotImplementedException();
        }

        public void InsertEmailFolderType(DictionaryEmailFolderType emailFolderType)
        {
            throw new NotImplementedException();
        }

        public DictionaryEmailServer GetEmailServer(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmailServer(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmailServer(DictionaryEmailServer emailServer)
        {
            throw new NotImplementedException();
        }

        public void InsertEmailServer(DictionaryEmailServer emailServer)
        {
            throw new NotImplementedException();
        }

        public DictionaryEmailServerParam GetEmailServerParam(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmailServerParam(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmailServerParam(DictionaryEmailServerParam emailServerParam)
        {
            throw new NotImplementedException();
        }

        public void InsertEmailServerParam(DictionaryEmailServerParam emailServerParam)
        {
            throw new NotImplementedException();
        }

        public DictionaryHierarchy GetHierarchy(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteHierarchy(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateHierarchy(DictionaryHierarchy hierarchy)
        {
            throw new NotImplementedException();
        }

        public void InsertHierarchy(DictionaryHierarchy hierarchy)
        {
            throw new NotImplementedException();
        }

    }
}
