using System;
using System.Collections.Generic;
using System.Linq;
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
}
