using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.DAL.Models.Contexts
{
    public sealed class TwinkleDbContext : DbContext
    {
        public TwinkleDbContext() : base("TwinkleDbConnection") { }

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
        public DbSet<DictionaryEmailFolderType> EmailFolderTypes { get; set; }
        public DbSet<DictionaryHierarchy> Hierarchies { get; set; }
        #endregion

        #region Views
        public DbSet<ViewVehicle> ViewVehicles { get; set; }
        public DbSet<ViewAssignedDeal> ViewAssignedDeals { get; set; }
        #endregion
    }
}
