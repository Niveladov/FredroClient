using FredroDAL.Models.DatabaseObjectModels.Tables;
using FredroMailService.Models;
using System.Collections.Generic;
using System.ServiceModel;
using FredroMailService.ExtraClasses;

namespace FredroMailService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    public class MailService : IMailService
    {
        private IMailServer _mailServerConnection;

        public MailService()
        {
            FredroHelper.SaveTestData();
            _mailServerConnection = new EmailServerConnection();
        }

        public IEnumerable<TheMessage> GetAllMails()
        {
            return _mailServerConnection.GetAllMails();
        }

        public void RemoveMail(string Id)
        {
            _mailServerConnection.RemoveMail(Id);
        }

        public void SendMail(TheMessage message)
        {
            _mailServerConnection.SendMail(message);
        }

        public void UpdateMail(TheMessage message)
        {
            _mailServerConnection.UpdateMail(message);
        }

    }

}
