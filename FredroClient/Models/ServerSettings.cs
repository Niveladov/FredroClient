using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class ServerSettings
    {
        public PopProtocol Pop { get; set; } = new PopProtocol();
        public SmtpProtocol Smtp { get; set; } = new SmtpProtocol();
        public ImapProtocol Imap { get; set; } = new ImapProtocol();
        
    }

    internal sealed class PopProtocol : Protocol { }
    internal sealed class SmtpProtocol : Protocol { }
    internal sealed class ImapProtocol : Protocol { }

    internal abstract class Protocol
    {
        public string Hostname { get; set; }
        public bool UseSsl { get; set; }
        public int Port { get; set; }
    }
    
}
