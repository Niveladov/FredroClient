using DevExpress.XtraEditors;
using FredroClient.ExtraClasses;
using FredroClient.MailService;
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
    internal sealed class MailModel : IMailServiceCallback
    {
        private MailServiceClient _serviceClient;

        public Credentials Creds { get; }
        public List<TheMail> MyMails { get; }
        
        public event EventHandler NewMailsRecieved;

        public MailModel(Credentials creds)
        {
            Creds = creds;
            MyMails = new List<TheMail>();
            var instanceContext = new InstanceContext(this);
            _serviceClient = new MailServiceClient(instanceContext, "NetTcpBinding_IMailService");
            //LoadMails();
        }

        public void LoadMails()
        {
            if(Creds.Login.Equals(7.ToString()))
            {
                Creds.Login = "re";
                Creds.Password = "re";
            }
            else
            {
                ////"recent:" before username show messages 
                ////that were recieved during last 30 days messages
                try
                {
                    _serviceClient.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
                    _serviceClient.ClientCredentials.UserName.UserName = Creds.Login;
                    _serviceClient.ClientCredentials.UserName.Password = Creds.Password;
                    _serviceClient.Join();
                }
                catch (MessageSecurityException)
                {
                    FredroMessageBox.ShowError("Не удаётся войти. Пожалуйста, проверьте правильность написания\r\nлогина и пароля");
                    _serviceClient.Abort();
                }
                catch (TimeoutException exception)
                {
                    FredroMessageBox.ShowError($"Timeout error: {exception.Message}");
                    _serviceClient.Abort();
                }
                catch (FaultException ex)
                {
                    FredroMessageBox.ShowError(ex.Message + ex.Code.Name);
                    _serviceClient.Abort();
                }
                catch (CommunicationException exception)
                {
                    FredroMessageBox.ShowError($"Communication error: {exception.Message}");
                    _serviceClient.Abort();
                }
            }
        }

        public void SendNewMails(TheMail[] newMails)
        {
            MyMails.AddRange(newMails);
            NewMailsRecieved?.Invoke(this, EventArgs.Empty);
        }

    }

}
