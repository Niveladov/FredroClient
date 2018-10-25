using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.ExtraClasses
{
    internal class PortAttribute : Attribute
    {
        public int Port { get; set; }

        public PortAttribute(int port)
        {
            Port = port;
        }
    }

    internal class HostAttribute : Attribute
    {
        public string Host { get; set; }

        public HostAttribute(string host)
        {
            Host = host;
        }
    }

    internal class UseSslAttribute : Attribute
    {
        public bool UseSsl { get; set; }

        public UseSslAttribute(bool useSsl)
        {
            UseSsl = useSsl;
        }
    }


}
