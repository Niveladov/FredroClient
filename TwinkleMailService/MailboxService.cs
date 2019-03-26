using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.MailboxService.Models;
using System.Collections.Generic;
using System.ServiceModel;
using TwinklCRM.MailboxService.ExtraClasses;
using System;
using System.Threading;
using TwinklCRM.MailboxService.Models.Enums;

namespace TwinklCRM.MailboxService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class MailboxService : IMailboxService
    {
        private IMailTransferManager _mailTransferManager;
        private IMailDeliveryManager _mailDeliveryManager;
        private IDbDataManager _dbDataManager;

        public MailboxService()
        {
            try
            {
                _dbDataManager = new DbDataManager();
                _mailDeliveryManager = new EmailDeliveryManager(_dbDataManager);
                _mailTransferManager = new EmailTransferManager();
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
                _mailDeliveryManager.Join();
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
                _mailTransferManager.SendMail(mail);
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
                _dbDataManager.RemoveMail(Id);
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
                _dbDataManager.UpdateMail(mail);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<CachedEmailBox> GetUserEmailBoxes()
        {
            try
            {
                return _dbDataManager.GetUserEmailBoxes();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

    }

}
