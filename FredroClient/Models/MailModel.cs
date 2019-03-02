using DevExpress.XtraEditors;
using FredroClient.ExtraClasses;
using FredroClient.MailService;
using FredroDAL.Models;
using FredroDAL.Models.DatabaseObjectModels.Tables;
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
            _serviceClient.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            _serviceClient.ClientCredentials.UserName.UserName = Creds.Login;
            _serviceClient.ClientCredentials.UserName.Password = Creds.Password;
        }

        public void JoinToServer()
        {
            try
            {
                _serviceClient.Join();
            }
            catch (MessageSecurityException ex)
            {
                //FredroMessageBox.ShowError("Не удаётся войти. Пожалуйста, проверьте правильность написания\r\nлогина и пароля");
                _serviceClient.Abort();
                throw new ServerException("Не удаётся войти. Пожалуйста, проверьте правильность написания\r\nлогина и пароля", ex);
            }
            catch (TimeoutException ex)
            {
                //FredroMessageBox.ShowError($"Timeout error: {ex.Message}");
                _serviceClient.Abort();
                throw new ServerException("Возникла внутрення ошибка сервера. Timeout error.", ex);
            }
            catch (FaultException ex)
            {
                //FredroMessageBox.ShowError(ex.Message + ex.Code.Name);
                _serviceClient.Abort();
                throw new ServerException("Возникла внутрення ошибка сервера.", ex);
            }
            catch (CommunicationException ex)
            {
                //FredroMessageBox.ShowError($"Communication error: {ex.Message}");
                _serviceClient.Abort();
                throw new ServerException("Возникла внутрення ошибка сервера. Communication error.", ex);
            }
        }

        public void SendMail(TheMail mail)
        {
            try
            {
                _serviceClient.SendMail(mail);
            }
            catch (FaultException ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                _serviceClient.Abort();
            }
        }

        public void UpdateMail(TheMail mail)
        {
            try
            {
                _serviceClient.UpdateMail(mail);
            }
            catch (FaultException ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                _serviceClient.Abort();
            }
        }

        public void SendNewMails(TheMail[] newMails)
        {
            MyMails.AddRange(newMails);
            NewMailsRecieved?.Invoke(this, EventArgs.Empty);
        }

    }

}
