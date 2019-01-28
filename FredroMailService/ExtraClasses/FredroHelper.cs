using FredroDAL.Models.Contexts;
using FredroDAL.Models.DatabaseObjectModels.Tables;
using FredroDAL.Models.DatabaseObjectModels.Tables.Dictionaries;
using System;

namespace FredroMailService.ExtraClasses
{
    internal static class FredroHelper
    {
        internal static void SaveTestData()
        {
            using (var db = new FredroDbContext())
            {
                var desTest = new DictionaryEmailServer()
                {
                    IsDel = false,
                    CreatedBy = -1,
                    CreationDate = DateTime.Now,
                    Caption = "TEST666"
                };
                db.EmailServers.Add(desTest);

                var dttTest = new DictionaryTripType()
                {
                    IsDel = false,
                    CreatedBy = -1,
                    CreationDate = DateTime.Now,
                    Name = "TEST666"
                };
                db.TripTypes.Add(dttTest);

                var dvtTest = new DictionaryVehicleType()
                {
                    IsDel = false,
                    CreatedBy = -1,
                    CreationDate = DateTime.Now,
                    Name = "TEST666"
                };
                db.VehicleTypes.Add(dvtTest);

                var cebTest = new CachedEmailBox()
                {
                    IsDel = false,
                    CreatedBy = -1,
                    CreationDate = DateTime.Now,
                    Login = "TEST666",
                };
                db.CachedEmailBoxes.Add(cebTest);

                var customerTest = new Customer()
                {
                    IsDel = false,
                    CreatedBy = -1,
                    CreationDate = DateTime.Now,
                    SubjectName = "TEST666"
                };
                db.Customers.Add(customerTest);

                var performerTest = new Performer()
                {
                    IsDel = false,
                    CreatedBy = -1,
                    CreationDate = DateTime.Now,
                    SubjectName = "TEST666"
                };
                db.Performers.Add(performerTest);

                var dealTest = new Deal()
                {
                    IsDel = false,
                    CreatedBy = -1,
                    CreationDate = DateTime.Now,
                    Route = "TEST666"
                };
                db.Deals.Add(dealTest);

                var vehicleTest = new Vehicle()
                {
                    IsDel = false,
                    CreatedBy = -1,
                    CreationDate = DateTime.Now,
                    Name = "TEST666",
                };
                db.Vehicles.Add(vehicleTest);

                var userTest = new User()
                {
                    IsDel = false,
                    CreatedBy = -1,
                    CreationDate = DateTime.Now,
                    Login = "TEST666",
                };
                db.Users.Add(userTest);

                db.SaveChanges();
            }
        }

    }

}
