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
        

        public List<TheMessage> GetTheMessageList()
        {
            var hostParams = _currentServer.Value.GetHostParameters();
            //"recent:" before username show messages 
            //that were recieved during last 30 days messages
            var username = $"recent:{Login}";
            var messages = FredroHelper.FetchAllMessages(hostParams.Hostname, hostParams.Port.Value,
                hostParams.UseSsl.Value, username, Password);
            var theMessages = new List<TheMessage>();
            foreach (var message in messages)
            {
                theMessages.Add(message.GetTheMessage());
            }
            return theMessages;
        }


    }
}
