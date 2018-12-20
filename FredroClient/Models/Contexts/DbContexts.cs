using FredroClient.Models.DatabaseObjectModels.Tables;
using FredroClient.Models.DatabaseObjectModels.Tables.Dictionaries;
using FredroClient.Models.DatabaseObjectModels.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models.Contexts
{
    #region Simple tables
    internal sealed class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public CustomerContext() : base("FredroDbConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<CustomerContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

    internal sealed class PerformerContext : DbContext
    {
        public DbSet<Performer> Performers { get; set; }
        public PerformerContext() : base("FredroDbConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<PerformerContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

    internal sealed class VehicleContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public VehicleContext() : base("FredroDbConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<VehicleContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

    internal sealed class DealContext : DbContext
    {
        public DbSet<Deal> Deals { get; set; }
        public DealContext() : base("FredroDbConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DealContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

    internal sealed class TheMessageContext : DbContext
    {
        public DbSet<TheMessage> Messages { get; set; }
        public TheMessageContext() : base("FredroDbConnection") { }
    }
    #endregion

    #region Dictionary tables
    internal sealed class DictionaryVehicleTypeContext : DbContext
    {
        public DbSet<DictionaryVehicleType> VehicleTypes { get; set; }
        public DictionaryVehicleTypeContext() : base("FredroDbConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DictionaryVehicleTypeContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

    internal sealed class DictionaryTripTypeContext : DbContext
    { 
        public DbSet<DictionaryTripType> TripTypes { get; set; }
        public DictionaryTripTypeContext() : base("FredroDbConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DictionaryTripTypeContext>(null);
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<DictionaryTripType>().ToTable("DictionaryTripTypes");
        }
    }
    #endregion

    #region Views
    internal sealed class ViewVehicleContext : DbContext
    {
        public DbSet<ViewVehicle> ViewVehicles { get; set; }
        public ViewVehicleContext() : base("FredroDbConnection") { }
    }

    internal sealed class ViewAssignedDealContext : DbContext
    {
        public DbSet<ViewAssignedDeal> ViewAssignedDeals { get; set; }
        public ViewAssignedDealContext() : base("FredroDbConnection") { }
    }
    #endregion

    public static class DbSetExtensions
    {
        public static T AddIfNotExists<T>(this DbSet<T> dbSet, T entity, Expression<Func<T, bool>> predicate = null) where T : class, new()
        {
            var exists = predicate != null ? dbSet.Any(predicate) : dbSet.Any();
            return !exists ? dbSet.Add(entity) : null;
        }
    }
}
