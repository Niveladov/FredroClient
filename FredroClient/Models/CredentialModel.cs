using DevExpress.XtraEditors;
using FredroClient.ExtraClasses;
using FredroClient.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel.Security;
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
        public BindingList<FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage> Messages { get; private set; }
        public ServerSettings Settings { get; private set; }

        private void RefreshServerSettings()
        {
            var currentServer = (Server)_currentServerId;
            Settings = currentServer.GetServerSettings();
        }

        public void LoadMessages()
        {
            string username = "";
            if(Creds.Username.Equals(7.ToString()))
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
                username = _currentServerId == 0 ? $"recent:{Creds.Username}" : Creds.Username;
            }
            if (Settings == null)
            {
                FredroMessageBox.ShowError("Не выбран почтовый сервер!");
            }
            //чистим все имэйлы из бд
            //FredroHelper.TruncateMessages();
            //получаем все имэйлы из удалённого сервера по хосту, порту и пользователю. 
            //var messages = FredroHelper.FetchAllMessages(Settings.Pop.Hostname, Settings.Pop.Port,
            //    Settings.Pop.UseSsl, username, Creds.Password);
            //if (messages == null || messages.Count == 0) return;
            ////преобразовываем
            //var myMessages = new List<TheMessage>();
            //foreach (var message in messages)
            //{
            //    var mess = message.GetTheMessage();
            //    mess.IsOutcoming = Creds.Username.Equals(mess.FromAddress);
            //    mess.IsIncoming = Creds.Username.Equals(mess.ToAddress);
            //    myMessages.Add(mess);
            //}
            ////сохраяняем в бд имэйлы
            //FredroHelper.SaveNewMessages(myMessages);
            //->
            //FredroHelper.SaveTestData();
            //Messages = FredroHelper.GetMessages();
            //<-
            var client = new MailService.MailServiceClient("NetTcpBinding_IMailService");
            client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            client.ClientCredentials.UserName.UserName = "1";
            client.ClientCredentials.UserName.Password = "";
            var theMessages = new BindingList<FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage>();
            foreach (var message in client.GetAllMails()) theMessages.Add(message);
            Messages = theMessages;
        }

    }

    internal sealed class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

}
