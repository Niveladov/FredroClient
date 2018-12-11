using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class TheMessageContext : DbContext
    {
        public DbSet<TheMessage> Messages { get; set; }

        public TheMessageContext() : base("FredroDbConnection") { }

    }
}
