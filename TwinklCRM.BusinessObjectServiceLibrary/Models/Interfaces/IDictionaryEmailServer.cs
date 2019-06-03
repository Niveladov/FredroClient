using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces
{
    internal interface IDictionaryEmailServer
    {
        DictionaryEmailServer GetEmailServer(int id);
        void DeleteEmailServer(int id);
        void UpdateEmailServer(DictionaryEmailServer emailServer);
        void InsertEmailServer(DictionaryEmailServer emailServer);
        IEnumerable<DictionaryEmailServer> GetAllEmailServers();
    }

    [ServiceContract]
    public interface IDictionaryEmailServerService
    {
        [OperationContract]
        DictionaryEmailServer GetEmailServer(int id);

        [OperationContract]
        void DeleteEmailServer(int id);

        [OperationContract]
        void UpdateEmailServer(DictionaryEmailServer emailServer);

        [OperationContract]
        void InsertEmailServer(DictionaryEmailServer emailServer);

        [OperationContract]
        IEnumerable<DictionaryEmailServer> GetAllEmailServers();
    }
}
