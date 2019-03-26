using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.Contexts;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Views;

namespace TwinklCRM.SchedulerService.Models
{
    internal interface IDbDataManager
    {
        IEnumerable<ViewVehicle> GetResources();

        void AssignAppointment(int appointmentId, int resourceId);

        void CancelAppointment(int appointmentId);

        void DeleteAppointment(int appointmentId);

        IEnumerable<ViewAssignedDeal> GetAssignedAppointments();

        IEnumerable<Deal> GetFreeAppointments();
    }

    internal sealed class DbDataManager : IDbDataManager
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

        public IEnumerable<ViewAssignedDeal> GetAssignedAppointments()
        {
            using (var db = new TwinkleDbContext())
            {
                db.ViewAssignedDeals.Load();
                return db.ViewAssignedDeals.ToList();
            }
        }

        public IEnumerable<Deal> GetFreeAppointments()
        {
            using (var db = new TwinkleDbContext())
            {
                db.Deals.Load();
                return db.Deals.Where(x => x.VehicleId == null).ToList();
            }
        }

    }

}
