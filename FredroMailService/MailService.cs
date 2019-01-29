using FredroDAL.Models.DatabaseObjectModels.Tables;
using FredroMailService.Models;
using System.Collections.Generic;
using System.ServiceModel;
using FredroMailService.ExtraClasses;
using System;

namespace FredroMailService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    public class MailService : IMailService
    {
        private IMailServer _mailServerConnection;

        public MailService()
        {
            try
            {
                //FredroHelper.SaveTestData();
                _mailServerConnection = new EmailServerConnection();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<TheMessage> GetAllMails()
        {
            try
            {
                return _mailServerConnection.GetAllMails();
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

        public void SendMail(TheMessage message)
        {
            try
            {
                _mailServerConnection.SendMail(message);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateMail(TheMessage message)
        {
            try
            {
                _mailServerConnection.UpdateMail(message);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

    }

}
