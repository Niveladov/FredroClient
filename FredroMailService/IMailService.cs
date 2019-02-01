using FredroDAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FredroMailService
{
    [ServiceContract(CallbackContract = typeof(IMailCallback))]
    public interface IMailService
    {
        [OperationContract]
        void Join();

        [OperationContract]
        void SendMail(TheMail mail);

        [OperationContract]
        void UpdateMail(TheMail mail);
        
        [OperationContract]
        void RemoveMail(string Id);
    }

    public interface IMailCallback
    {
        [OperationContract]
        void SendNewMails(IEnumerable<TheMail> newMails);
    }

}
