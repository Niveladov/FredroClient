using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.MailboxServiceLibrary
{
    [ServiceContract(CallbackContract = typeof(IMailboxCallback))]
    public interface IMailboxService
    {
        [OperationContract(IsOneWay = true)]
        void Join();
        
        [OperationContract]
        void SendMail(TheMail mail);

        [OperationContract(IsOneWay = true)]
        void UpdateMail(TheMail mail);
        
        [OperationContract(IsOneWay = true)]
        void RemoveMail(string Id);

        [OperationContract]
        IEnumerable<CachedEmailBox> GetUserEmailBoxes();
    }

    public interface IMailboxCallback
    {
        [OperationContract(IsOneWay = true)]
        void SendNewInboxMails(IEnumerable<TheMail> newMails);

        [OperationContract(IsOneWay = true)]
        void SendNewOutboxMails(IEnumerable<TheMail> newMails);

        [OperationContract(IsOneWay = true)]
        void SendNewDeletedMails(IEnumerable<TheMail> newMails);

        [OperationContract(IsOneWay = true)]
        void SendNewSpamMails(IEnumerable<TheMail> newMails);
    }

}
