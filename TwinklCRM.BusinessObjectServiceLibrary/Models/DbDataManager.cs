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
        #region Customer

        public Customer GetCustomer(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.Customers.Find(id);
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

        public void UpdateCustomer(Customer customer)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertCustomer(Customer customer)
        {
            using (var db = new TwinkleDbContext())
            {
                customer.CreatedBy = -1;
                customer.IsDel = false;
                customer.CreationDate = DateTime.Now;
                db.Customers.Add(customer);
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

        #endregion

        #region Performer

        public Performer GetPerformer(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.Performers.Find(id);
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

        public void UpdatePerformer(Performer performer)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Entry(performer).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertPerformer(Performer performer)
        {
            using (var db = new TwinkleDbContext())
            {
                performer.CreatedBy = -1;
                performer.IsDel = false;
                performer.CreationDate = DateTime.Now;
                db.Performers.Add(performer);
                db.SaveChanges();
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

        #endregion

        #region Deal

        public Deal GetDeal(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.Deals.Find(id);
            }
        }

        public void DeleteDeal(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                var deal = db.Deals.Find(id);
                db.Deals.Remove(deal);
                db.SaveChanges();
            }
        }

        public void UpdateDeal(Deal deal)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Entry(deal).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertDeal(Deal deal)
        {
            using (var db = new TwinkleDbContext())
            {
                deal.CreatedBy = -1;
                deal.IsDel = false;
                deal.CreationDate = DateTime.Now;
                db.Deals.Add(deal);
                db.SaveChanges();
            }
        }

        public IEnumerable<Deal> GetAllDeals()
        {
            using (var db = new TwinkleDbContext())
            {
                db.Deals.Load();
                return db.Deals.ToList();
            }
        }

        #endregion

        #region Vehicle

        public Vehicle GetVehicle(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.Vehicles.Find(id);
            }
        }

        public void DeleteVehicle(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                var vehicle = db.Vehicles.Find(id);
                db.Vehicles.Remove(vehicle);
                db.SaveChanges();
            }
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertVehicle(Vehicle vehicle)
        {
            using (var db = new TwinkleDbContext())
            {
                vehicle.CreatedBy = -1;
                vehicle.IsDel = false;
                vehicle.CreationDate = DateTime.Now;
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
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

        #endregion

        #region DictionaryTripType

        public DictionaryTripType GetTripType(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.TripTypes.Find(id);
            }
        }

        public void DeleteTripType(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                var tripType = db.TripTypes.Find(id);
                db.TripTypes.Remove(tripType);
                db.SaveChanges();
            }
        }

        public void UpdateTripType(DictionaryTripType tripType)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Entry(tripType).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertTripType(DictionaryTripType tripType)
        {
            using (var db = new TwinkleDbContext())
            {
                tripType.CreatedBy = -1;
                tripType.IsDel = false;
                tripType.CreationDate = DateTime.Now;
                db.TripTypes.Add(tripType);
                db.SaveChanges();
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

        #endregion

        #region DictionaryVehicleType

        public DictionaryVehicleType GetVehicleType(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.VehicleTypes.Find(id);
            }
        }

        public void DeleteVehicleType(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                var vehicleType = db.VehicleTypes.Find(id);
                db.VehicleTypes.Remove(vehicleType);
                db.SaveChanges();
            }
        }

        public void UpdateVehicleType(DictionaryVehicleType vehicleType)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Entry(vehicleType).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertVehicleType(DictionaryVehicleType vehicleType)
        {
            using (var db = new TwinkleDbContext())
            {
                vehicleType.CreatedBy = -1;
                vehicleType.IsDel = false;
                vehicleType.CreationDate = DateTime.Now;
                db.VehicleTypes.Add(vehicleType);
                db.SaveChanges();
            }
        }

        public IEnumerable<DictionaryVehicleType> GetAllVehicleTypes()
        {
            using (var db = new TwinkleDbContext())
            {
                db.VehicleTypes.Load();
                return db.VehicleTypes.ToList();
            }
        }

        #endregion

        #region DictionaryEmailFolderType

        public DictionaryEmailFolderType GetEmailFolderType(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.EmailFolderTypes.Find(id);
            }
        }

        public void DeleteEmailFolderType(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                var emailFolderType = db.EmailFolderTypes.Find(id);
                db.EmailFolderTypes.Remove(emailFolderType);
                db.SaveChanges();
            }
        }

        public void UpdateEmailFolderType(DictionaryEmailFolderType emailFolderType)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Entry(emailFolderType).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertEmailFolderType(DictionaryEmailFolderType emailFolderType)
        {
            using (var db = new TwinkleDbContext())
            {
                emailFolderType.CreatedBy = -1;
                emailFolderType.IsDel = false;
                emailFolderType.CreationDate = DateTime.Now;
                db.EmailFolderTypes.Add(emailFolderType);
                db.SaveChanges();
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

        #endregion

        #region DictionaryEmailServer

        public DictionaryEmailServer GetEmailServer(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.EmailServers.Find(id);
            }
        }

        public void DeleteEmailServer(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                var emailServer = db.EmailServers.Find(id);
                db.EmailServers.Remove(emailServer);
                db.SaveChanges();
            }
        }

        public void UpdateEmailServer(DictionaryEmailServer emailServer)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Entry(emailServer).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertEmailServer(DictionaryEmailServer emailServer)
        {
            using (var db = new TwinkleDbContext())
            {
                emailServer.CreatedBy = -1;
                emailServer.IsDel = false;
                emailServer.CreationDate = DateTime.Now;
                db.EmailServers.Add(emailServer);
                db.SaveChanges();
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

        #endregion

        #region DictionaryEmailServerParam

        public DictionaryEmailServerParam GetEmailServerParam(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.EmailServerParams.Find(id);
            }
        }

        public void DeleteEmailServerParam(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                var emailServerParam = db.EmailServerParams.Find(id);
                db.EmailServerParams.Remove(emailServerParam);
                db.SaveChanges();
            }
        }

        public void UpdateEmailServerParam(DictionaryEmailServerParam emailServerParam)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Entry(emailServerParam).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertEmailServerParam(DictionaryEmailServerParam emailServerParam)
        {
            using (var db = new TwinkleDbContext())
            {
                emailServerParam.CreatedBy = -1;
                emailServerParam.IsDel = false;
                emailServerParam.CreationDate = DateTime.Now;
                db.EmailServerParams.Add(emailServerParam);
                db.SaveChanges();
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

        #endregion

        #region DictionaryHierarchy

        public DictionaryHierarchy GetHierarchy(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.Hierarchies.Find(id);
            }
        }

        public void DeleteHierarchy(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                var hierarchy = db.Hierarchies.Find(id);
                db.Hierarchies.Remove(hierarchy);
                db.SaveChanges();
            }
        }

        public void UpdateHierarchy(DictionaryHierarchy hierarchy)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Entry(hierarchy).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertHierarchy(DictionaryHierarchy hierarchy)
        {
            using (var db = new TwinkleDbContext())
            {
                hierarchy.CreatedBy = -1;
                hierarchy.IsDel = false;
                hierarchy.CreationDate = DateTime.Now;
                db.Hierarchies.Add(hierarchy);
                db.SaveChanges();
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

        #endregion

        #region DictionaryVehicleCapacityColorService

        public DictionaryVehicleCapacityColor GetVehicleCapacityColor(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                return db.VehicleCapacityColors.Find(id);
            }
        }

        public void DeleteVehicleCapacityColor(int id)
        {
            using (var db = new TwinkleDbContext())
            {
                var vehicleCapacityColor = db.VehicleCapacityColors.Find(id);
                db.VehicleCapacityColors.Remove(vehicleCapacityColor);
                db.SaveChanges();
            }
        }

        public void UpdateVehicleCapacityColor(DictionaryVehicleCapacityColor vehicleCapacityColor)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Entry(vehicleCapacityColor).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertVehicleCapacityColor(DictionaryVehicleCapacityColor vehicleCapacityColor)
        {
            using (var db = new TwinkleDbContext())
            {
                vehicleCapacityColor.CreatedBy = -1;
                vehicleCapacityColor.IsDel = false;
                vehicleCapacityColor.CreationDate = DateTime.Now;
                db.VehicleCapacityColors.Add(vehicleCapacityColor);
                db.SaveChanges();
            }
        }

        public IEnumerable<DictionaryVehicleCapacityColor> GetAllVehicleCapacityColors()
        {
            using (var db = new TwinkleDbContext())
            {
                db.VehicleCapacityColors.Load();
                return db.VehicleCapacityColors.ToList();
            }
        }
        
        #endregion

    }

}
