using FredroDAL.Models.DatabaseObjectModels.Tables;
using FredroDAL.Models.DatabaseObjectModels.Tables.Dictionaries;
using FredroDAL.Models.DatabaseObjectModels.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroDAL.Models.Contexts
{
    public sealed class FredroDbContext : DbContext
    {
        public FredroDbContext() : base("FredroDbConnection") { }

        #region Simple tables
        public DbSet<CachedEmailBox> CachedEmailBoxes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Performer> Performers { get; set; }
        public DbSet<TheMail> Mails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        #endregion

        #region Dictionary tables
        public DbSet<DictionaryEmailServer> EmailServers { get; set; }
        public DbSet<DictionaryVehicleType> VehicleTypes { get; set; }
        public DbSet<DictionaryTripType> TripTypes { get; set; }
        #endregion

        #region Views
        public DbSet<ViewVehicle> ViewVehicles { get; set; }
        public DbSet<ViewAssignedDeal> ViewAssignedDeals { get; set; }
        #endregion
    }
}
