using System;
using System.Collections.Generic;
using System.Linq;
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
}
