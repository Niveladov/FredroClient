using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroMailService.ExtraClasses
{
    internal sealed class PopAttribute : ProtocolAttribute { }

    internal sealed class SmtpAttribute : ProtocolAttribute { }

    internal sealed class ImapAttribute : ProtocolAttribute { }

    internal abstract class ProtocolAttribute : Attribute
    {
        public string Hostname { get; set; }
        public bool UseSsl { get; set; }
        public int Port { get; set; }
    }
}
