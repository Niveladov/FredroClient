using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroMailService.Models
{
    internal sealed class PopProtocol : ProtocolBase
    {
        public PopProtocol(string hostname, int port, bool useSsl) : base(hostname, port, useSsl) { }
    }
    internal sealed class SmtpProtocol : ProtocolBase
    {
        public SmtpProtocol(string hostname, int port, bool useSsl) : base(hostname, port, useSsl) { }
    }
    internal sealed class ImapProtocol : ProtocolBase
    {
        public ImapProtocol(string hostname, int port, bool useSsl) : base(hostname, port, useSsl) { }
    }

    internal class ProtocolBase : IProtocol
    {
        protected ProtocolBase(string hostname, int port, bool useSsl)
        {
            Hostname = hostname;
            Port = port;
            UseSsl = useSsl;
        }

        public string Hostname { get; }

        public int Port { get; }

        public bool UseSsl { get; }
    }

    internal interface IProtocol
    {
        string Hostname { get; }
        bool UseSsl { get; }
        int Port { get; }
    }

}
