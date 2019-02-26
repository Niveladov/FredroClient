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
        [OperationContract(IsOneWay = true)]
        void Join();

        [OperationContract(IsOneWay = true)]
        void SendMail(TheMail mail);

        [OperationContract(IsOneWay = true)]
        void UpdateMail(TheMail mail);
        
        [OperationContract(IsOneWay = true)]
        void RemoveMail(string Id);
    }

    public interface IMailCallback
    {
        [OperationContract(IsOneWay = true)]
        void SendNewMails(IEnumerable<TheMail> newMails);
    }

}
