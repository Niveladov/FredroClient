using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces
{
    internal interface IDictionaryTripType
    {
        DictionaryTripType GetTripType(int id);
        void DeleteTripType(int id);
        void UpdateTripType(DictionaryTripType tripType);
        void InsertTripType(DictionaryTripType tripType);
        IEnumerable<DictionaryTripType> GetAllTripTypes();
    }
}
