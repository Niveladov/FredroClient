using DevExpress.XtraEditors;
using FredroClient.ExtraClasses;
using FredroDAL.Models;
using FredroDAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FredroClient.Models
{
    internal sealed class CredentialModel
    {
        public Credentials Creds { get; set; } = new Credentials();
        public BindingList<TheMail> Mails { get; private set; }

        public void LoadMessages()
        {
            string username = "";
            if(Creds.Login.Equals(7.ToString()))
            {
                Creds.Login = "figamalum@gmail.com";
                username = "recent:figamalum@gmail.com";
                Creds.Password = "ghekkafigamalum1994";
            }
            else
            {
                //"recent:" before username show messages 
                //that were recieved during last 30 days messages
                username =/* _currentServerId == 0 ? $"recent:{Creds.Username}" : */Creds.Login;
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
            try
            {
                var client = new MailService.MailServiceClient("NetTcpBinding_IMailService");
                client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
                client.ClientCredentials.UserName.UserName = "Admin";
                client.ClientCredentials.UserName.Password = "Admin";
                var theMessages = new BindingList<TheMail>();
                foreach (var message in client.GetAllMails()) theMessages.Add(message);
                Mails = theMessages;
            }
            catch (MessageSecurityException)
            {
                FredroMessageBox.ShowError("Не удаётся войти. Пожалуйста, проверьте правильность написания\r\nлогина и пароля");
            }
            //catch (FaultException ex)
            //{
            //    FredroMessageBox.ShowError(ex.Message + ex.Code.Name);
            //}
        }

    }

}
