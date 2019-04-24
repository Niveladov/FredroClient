using DevExpress.XtraEditors;
using TwinklCRM.Client.ExtraClasses;
using TwinklCRM.Client.MailboxService;
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
using System.Collections.ObjectModel;
using TwinklCRM.Client.BusinessObjectService;

namespace TwinklCRM.Client.Models
{
    internal sealed class MailModel : IMailboxServiceCallback
    {
        private readonly Credentials _creds;
        private bool _isJoined = false;
        
        public BusinessObjectServiceClient BoServiceClient { get; }
        public MailboxServiceClient ServiceClient { get; }

        public ObservableCollection<TheMail> InboxMails { get; }
        public ObservableCollection<TheMail> OutboxMails { get; }
        public ObservableCollection<TheMail> DeletedMails { get; }
        public ObservableCollection<TheMail> SpamMails { get; }

        public MailModel(Credentials creds, BusinessObjectServiceClient boServiceClient)
        {
            _creds = creds;
            BoServiceClient = boServiceClient;
            InboxMails = new ObservableCollection<TheMail>();
            OutboxMails = new ObservableCollection<TheMail>();
            DeletedMails = new ObservableCollection<TheMail>();
            SpamMails = new ObservableCollection<TheMail>();

            var instanceContext = new InstanceContext(this);
            ServiceClient = new MailboxServiceClient(instanceContext, "NetTcpBinding_IMailboxService");
            ServiceClient.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            ServiceClient.ClientCredentials.UserName.UserName = _creds.Login;
            ServiceClient.ClientCredentials.UserName.Password = _creds.Password;
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

        public void CloseServerConnection()
        {
            try
            {
                ServiceClient.Stop();
                ServiceClient.Close();
            }
            catch
            {
                ServiceClient.Abort();
                throw new ServerException("Опа.. что-то пошло не так");
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

        #region Callback
        public void SendNewInboxMail(TheMail mail)
        {
            InboxMails.Add(mail);
        }

        public void SendNewOutboxMail(TheMail mail)
        {
            OutboxMails.Add(mail);
        }

        public void SendNewDeletedMail(TheMail mail)
        {
            DeletedMails.Add(mail);
        }

        public void SendNewSpamMail(TheMail mail)
        {
            SpamMails.Add(mail);
        }
        #endregion

    }

}
