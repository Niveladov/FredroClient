using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces
{
    internal interface IDictionaryEmailServerParam
    {
        DictionaryEmailServerParam GetEmailServerParam(int id);
        void DeleteEmailServerParam(int id);
        void UpdateEmailServerParam(DictionaryEmailServerParam emailServerParam);
        void InsertEmailServerParam(DictionaryEmailServerParam emailServerParam);
        IEnumerable<DictionaryEmailServerParam> GetAllEmailServerParams();
    }

    [ServiceContract]
    public interface IDictionaryEmailServerParamService
    {
        [OperationContract]
        DictionaryEmailServerParam GetEmailServerParam(int id);

        [OperationContract]
        void DeleteEmailServerParam(int id);

        [OperationContract]
        void UpdateEmailServerParam(DictionaryEmailServerParam emailServerParam);

        [OperationContract]
        void InsertEmailServerParam(DictionaryEmailServerParam emailServerParam);

        [OperationContract]
        IEnumerable<DictionaryEmailServerParam> GetAllEmailServerParams();
    }
}
