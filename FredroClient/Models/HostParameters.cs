using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class HostParameters
    {
        public string Hostname { get; set; }
        public bool? UseSsl { get; set; }
        public int? Port { get; set; }

    }
}
