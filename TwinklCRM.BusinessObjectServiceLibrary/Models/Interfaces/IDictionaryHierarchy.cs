using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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

    [ServiceContract]
    public interface IDictionaryHierarchyService
    {
        [OperationContract]
        DictionaryHierarchy GetHierarchy(int id);

        [OperationContract]
        void DeleteHierarchy(int id);

        [OperationContract]
        void UpdateHierarchy(DictionaryHierarchy hierarchy);

        [OperationContract]
        void InsertHierarchy(DictionaryHierarchy hierarchy);

        [OperationContract]
        IEnumerable<DictionaryHierarchy> GetAllHierarchies();
    }
}
