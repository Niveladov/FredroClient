﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinkleDAL.Models.Contexts;
using TwinkleDAL.Models.DatabaseObjectModels.Views;

namespace TwinkleSchedulerService.Models
{
    internal interface ISchedulerDataManager
    {
        IEnumerable<ViewVehicle> GetResources();

        void AssignAppointment(int appointmentId, int resourceId);

        void CancelAppointment(int appointmentId);

        void DeleteAppointment(int appointmentId);
    }

    internal sealed class SchedulerDataManager : ISchedulerDataManager
    {
        public IEnumerable<ViewVehicle> GetResources()
        {
            using (var db = new TwinkleDbContext())
            {
                db.ViewVehicles.Load();
                return db.ViewVehicles.ToList();
            }
        }

        public void AssignAppointment(int appointmentId, int resourceId)
        {
            using (var db = new TwinkleDbContext())
            {
                var appt = db.Deals.Find(appointmentId);
                appt.VehicleId = resourceId;
                db.SaveChanges();
            }
        }

        public void CancelAppointment(int appointmentId)
        {
            using (var db = new TwinkleDbContext())
            {
                var appt = db.Deals.Find(appointmentId);
                appt.VehicleId = null;
                db.SaveChanges();
            }
        }

        public void DeleteAppointment(int appointmentId)
        {
            using (var db = new TwinkleDbContext())
            {
                var appt = db.Mails.Find(appointmentId);
                db.Mails.Remove(appt);
                db.SaveChanges();
            }
        }
    }

}
