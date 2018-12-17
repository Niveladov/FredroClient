using FredroClient.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models.Contexts
{
    internal sealed class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public CustomerContext() : base("FredroDbConnection") { }
    }

    internal sealed class PerformerContext : DbContext
    {
        public DbSet<Performer> Performers { get; set; }
        public PerformerContext() : base("FredroDbConnection") { }
    }

    internal sealed class ViewVehicleContext : DbContext
    {
        public DbSet<ViewVehicle> ViewVehicles { get; set; }
        public ViewVehicleContext() : base("FredroDbConnection") { }
    }

    internal sealed class Dictionary_VehicleTypeContext : DbContext
    {
        public DbSet<Dictionary_VehicleType> VehicleTypes { get; set; }
        public Dictionary_VehicleTypeContext() : base("FredroDbConnection") { }
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
    }

    internal sealed class TheMessageContext : DbContext
    {
        public DbSet<TheMessage> Messages { get; set; }
        public TheMessageContext() : base("FredroDbConnection") { }
    }

    public static class DbSetExtensions
    {
        public static T AddIfNotExists<T>(this DbSet<T> dbSet, T entity, Expression<Func<T, bool>> predicate = null) where T : class, new()
        {
            var exists = predicate != null ? dbSet.Any(predicate) : dbSet.Any();
            return !exists ? dbSet.Add(entity) : null;
        }
    }
}
