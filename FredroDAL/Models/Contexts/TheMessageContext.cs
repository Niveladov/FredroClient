using FredroDAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroDAL.Models.Contexts
{
    public sealed class TheMessageContext : DbContext
    {
        public DbSet<TheMessage> Messages { get; set; }
        public TheMessageContext() : base("FredroDbConnection") { }
    }
}
