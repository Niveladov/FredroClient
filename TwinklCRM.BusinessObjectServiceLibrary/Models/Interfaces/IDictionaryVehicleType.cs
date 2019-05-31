using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces
{
    internal interface IDictionaryVehicleType
    {
        DictionaryVehicleType GetVehicleType(int id);
        void DeleteVehicleType(int id);
        void UpdateVehicleType(DictionaryVehicleType vehicleType);
        void InsertVehicleType(DictionaryVehicleType vehicleType);
        IEnumerable<DictionaryVehicleType> GetAllVehicleTypes();
    }
}
