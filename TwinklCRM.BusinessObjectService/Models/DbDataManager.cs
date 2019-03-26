﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.Contexts;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectService.Models
{
    internal interface IDbDataManager
    {        
        Performer GetPerformer(int id);
        void DeletePerformer(int id);
        void UpdatePerformer(int id);
        void InsertPerformer(Performer performer);
        
        Deal GetDeal(int id);
        void DeleteDeal(int id);
        void UpdateDeal(int id);
        void InsertDeal(Deal deal);
        
        IEnumerable<Customer> GetAllCustomers();
        IEnumerable<Performer> GetAllPerformers();
        IEnumerable<Vehicle> GetAllVehicles();
        IEnumerable<DictionaryTripType> GetAllTripTypes();
    }

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

        public void UpdateDeal(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerformer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
