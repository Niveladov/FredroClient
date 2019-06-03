using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces
{
    internal interface IDictionaryEmailFolderType
    {
        DictionaryEmailFolderType GetEmailFolderType(int id);
        void DeleteEmailFolderType(int id);
        void UpdateEmailFolderType(DictionaryEmailFolderType emailFolderType);
        void InsertEmailFolderType(DictionaryEmailFolderType emailFolderType);
        IEnumerable<DictionaryEmailFolderType> GetAllEmailFolderTypes();
    }

    [ServiceContract]
    public interface IDictionaryEmailFolderTypeService
    {
        [OperationContract]
        DictionaryEmailFolderType GetEmailFolderType(int id);

        [OperationContract]
        void DeleteEmailFolderType(int id);

        [OperationContract]
        void UpdateEmailFolderType(DictionaryEmailFolderType emailFolderType);

        [OperationContract]
        void InsertEmailFolderType(DictionaryEmailFolderType emailFolderType);

        [OperationContract]
        IEnumerable<DictionaryEmailFolderType> GetAllEmailFolderTypes();
    }
}
