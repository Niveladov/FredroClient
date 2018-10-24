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


}
