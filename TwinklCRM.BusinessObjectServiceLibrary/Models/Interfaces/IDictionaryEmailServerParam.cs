using System;
using System.Collections.Generic;
using System.Linq;
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
}
