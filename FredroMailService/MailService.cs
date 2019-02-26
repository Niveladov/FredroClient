using FredroDAL.Models.DatabaseObjectModels.Tables;
using FredroMailService.Models;
using System.Collections.Generic;
using System.ServiceModel;
using FredroMailService.ExtraClasses;
using System;
using System.Threading;

namespace FredroMailService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class MailService : IMailService
    {
        private IMailServer _mailServerConnection;

        public MailService()
        {
            try
            {
                _mailServerConnection = new EmailServerConnection();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void Join()
        {
            try
            {
                _mailServerConnection.Join();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void RemoveMail(string Id)
        {
            try
            {
                _mailServerConnection.RemoveMail(Id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void SendMail(TheMail mail)
        {
            try
            {
                _mailServerConnection.SendMail(mail);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateMail(TheMail mail)
        {
            try
            {
                _mailServerConnection.UpdateMail(mail);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

    }

}
