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

        private int? _hostnameId = null;
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
        public List<TheMessage> Messages { get; private set; }

        public void InitMessages()
        {
            HostParameters hostParams = null;
            string username = "figamalum@gmail.com";

            if(Login.Equals(1.ToString()))
            {
                Login = "figamalum@gmail.com";
                hostParams = new HostParameters();
                hostParams.Hostname = "pop.gmail.com";
                hostParams.Port = 995;
                hostParams.UseSsl = true;
                username = "recent:figamalum@gmail.com";
                Password = "ghekkafigamalum1994";

            }
            else
            {
                hostParams = _currentServer.Value.GetHostParameters();
                //"recent:" before username show messages 
                //that were recieved during last 30 days messages
                username = $"recent:{Login}";

            }
            var messages = FredroHelper.FetchAllMessages(hostParams.Hostname, hostParams.Port.Value,
                hostParams.UseSsl.Value, username, Password);
            if (messages == null) return;
            
            Messages = new List<TheMessage>();
            foreach (var message in messages)
            {
                Messages.Add(message.GetTheMessage());
            }
        }

        public void SendNew(TheMessage message, string login, string password)
        {
            FredroHelper.SendEmailAsync(message, login, password).GetAwaiter();
        }

    }
}
