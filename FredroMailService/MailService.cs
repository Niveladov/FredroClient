using FredroDAL.Models.Contexts;
using FredroDAL.Models.DatabaseObjectModels.Tables;
using FredroDAL.Models;
using FredroMailService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FredroMailService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    public class MailService : IMailService
    {
        private IMailServer _mailServerConnection;

        public MailService(Credentials creds)
        {
            _mailServerConnection = new EmailServerConnection(creds);
        }

        public IEnumerable<TheMessage> GetAllMails()
        {
            return _mailServerConnection.GetAllMails();
        }

        public void RemoveMail(string Id)
        {
            _mailServerConnection.RemoveMail(Id);
        }

        public async Task RemoveMailAsync(string Id)
        {
            await _mailServerConnection.RemoveMailAsync(Id);
        }

        public void SendMail(TheMessage message)
        {
            _mailServerConnection.SendMail(message);
        }

        public async Task SendMailAsync(TheMessage message)
        {
            await _mailServerConnection.SendMailAsync(message);
        }

        public void UpdateMail(TheMessage message)
        {
            _mailServerConnection.UpdateMail(message);
        }

        public async Task UpdateMailAsync(TheMessage message)
        {
            await _mailServerConnection.UpdateMailAsync(message);
        }
    }
}
