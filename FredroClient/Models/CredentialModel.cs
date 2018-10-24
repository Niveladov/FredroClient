using FredroClient.ExtraClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class CredentialModel
    {
        private Hostname? _currentServer { get; set; }

        private int? _hostnameId;
        public int? HostnameId
        {
            get { return _hostnameId; }
            set
            {
                if (value != _hostnameId)
                {
                    _hostnameId = value;
                    _currentServer = (Hostname)_hostnameId;
                }
            }
        }

        public string Login { get; set; }
        public string Password { get; set; }
        
    }
}
