using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class VehicleContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public VehicleContext() : base("FredroDbConnection") { }
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
