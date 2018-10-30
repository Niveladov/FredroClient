using DevExpress.XtraEditors;
using FredroClient.ExtraClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FredroClient.Models
{
    internal sealed class CredentialModel
    {
        private int? _currentServerId = null;
        public int? CurrentServerId
        {
            get { return _currentServerId; }
            set
            {
                if (value != _currentServerId)
                {
                    _currentServerId = value;
                    RefreshServerSettings();
                }
            }
        }

        public Credentials Creds { get; set; } = new Credentials();
        public List<TheMessage> Messages { get; private set; }
        public ServerSettings Settings { get; private set; }

        private void RefreshServerSettings()
        {
            var currentServer = (Server)_currentServerId;
            Settings = currentServer.GetServerSettings();
        }

        public void LoadMessages()
        {
            string username = "";
            if(Creds.Username.Equals(1.ToString()))
            {
                Creds.Username = "figamalum@gmail.com";
                Settings = new ServerSettings();
                Settings.Pop.Hostname = "pop.gmail.com";
                Settings.Pop.Port = 995;
                Settings.Pop.UseSsl = true;
                Settings.Smtp.Hostname = "smtp.gmail.com";
                Settings.Smtp.Port = 587;
                Settings.Smtp.UseSsl = true;
                username = "recent:figamalum@gmail.com";
                Creds.Password = "ghekkafigamalum1994";
            }
            else
            {
                //"recent:" before username show messages 
                //that were recieved during last 30 days messages
                username = $"recent:{Creds.Username}";
            }
            if (Settings == null)
            {
                XtraMessageBox.Show("Не выбран почтовый сервер!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var messages = FredroHelper.FetchAllMessages(Settings.Pop.Hostname, Settings.Pop.Port,
                Settings.Pop.UseSsl, username, Creds.Password);
            if (messages == null) return;
            
            Messages = new List<TheMessage>();
            foreach (var message in messages)
            {
                var mess = message.GetTheMessage();
                mess.IsOutcoming = mess.FromAddress.Equals(Creds.Username);
                mess.IsIncoming = mess.ToAddress.Equals(Creds.Username);
                Messages.Add(mess);
            }
        }

    }

    internal sealed class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

}
