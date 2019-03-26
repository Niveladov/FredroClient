using DevExpress.XtraEditors;
using TwinklCRM.Client.ExtraClasses;
using TwinklCRM.Client.MailService;
using TwinklCRM.DAL.Models;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwinklCRM.Client.Models
{
    internal sealed class MailModel : IMailServiceCallback
    {
        private bool _isJoined = false;

        public MailServiceClient ServiceClient { get; }
        public Credentials Creds { get; }
        public List<TheMail> MyMails { get; }
        
        public event EventHandler NewMailsRecieved;

        public MailModel(Credentials creds)
        {
            Creds = creds;
            MyMails = new List<TheMail>();
            var instanceContext = new InstanceContext(this);
            ServiceClient = new MailServiceClient(instanceContext, "NetTcpBinding_IMailService");
            ServiceClient.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            ServiceClient.ClientCredentials.UserName.UserName = Creds.Login;
            ServiceClient.ClientCredentials.UserName.Password = Creds.Password;
        }

        public void JoinToServer()
        {
            try
            {
                if (!_isJoined)
                {
                    ServiceClient.Join();
                    _isJoined = true;
                }
            }
            catch (MessageSecurityException ex)
            {
                //FredroMessageBox.ShowError("Не удаётся войти. Пожалуйста, проверьте правильность написания\r\nлогина и пароля");
                ServiceClient.Abort();
                throw new ServerException("Не удаётся войти. Пожалуйста, проверьте правильность написания\r\nлогина и пароля", ex);
            }
            catch (TimeoutException ex)
            {
                //FredroMessageBox.ShowError($"Timeout error: {ex.Message}");
                ServiceClient.Abort();
                throw new ServerException("Возникла внутрення ошибка сервера. Timeout error.", ex);
            }
            catch (FaultException ex)
            {
                //FredroMessageBox.ShowError(ex.Message + ex.Code.Name);
                ServiceClient.Abort();
                throw new ServerException("Возникла внутрення ошибка сервера.", ex);
            }
            catch (CommunicationException ex)
            {
                //FredroMessageBox.ShowError($"Communication error: {ex.Message}");
                ServiceClient.Abort();
                throw new ServerException("Возникла внутрення ошибка сервера. Communication error.", ex);
            }
        }

        public void SendMail(TheMail mail)
        {
            try
            {
                ServiceClient.SendMail(mail);
            }
            catch (FaultException ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
                ServiceClient.Abort();
            }
        }

        public void UpdateMail(TheMail mail)
        {
            try
            {
                ServiceClient.UpdateMail(mail);
            }
            catch (FaultException ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
                ServiceClient.Abort();
            }
        }


        public void SendNewMails(TheMail[] newMails)
        {
            MyMails.AddRange(newMails);
            NewMailsRecieved?.Invoke(this, EventArgs.Empty);
        }
    }

}
