using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces
{
    internal interface IDictionaryHierarchy
    {
        DictionaryHierarchy GetHierarchy(int id);
        void DeleteHierarchy(int id);
        void UpdateHierarchy(DictionaryHierarchy hierarchy);
        void InsertHierarchy(DictionaryHierarchy hierarchy);
        IEnumerable<DictionaryHierarchy> GetAllHierarchies();
    }
}
