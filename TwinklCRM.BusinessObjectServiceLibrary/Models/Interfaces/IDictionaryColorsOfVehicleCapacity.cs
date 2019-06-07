using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces
{
    internal interface IDictionaryVehicleCapacityColor
    {
        DictionaryVehicleCapacityColor GetVehicleCapacityColor(int id);
        void DeleteVehicleCapacityColor(int id);
        void UpdateVehicleCapacityColor(DictionaryVehicleCapacityColor emailFolderType);
        void InsertVehicleCapacityColor(DictionaryVehicleCapacityColor emailFolderType);
        IEnumerable<DictionaryVehicleCapacityColor> GetVehicleCapacityColors();
    }
    
    [ServiceContract]
    public interface IDictionaryVehicleCapacityColorService
    {
        [OperationContract]
        DictionaryVehicleCapacityColor GetVehicleCapacityColor(int id);

        [OperationContract]
        void DeleteVehicleCapacityColor(int id);

        [OperationContract]
        void UpdateVehicleCapacityColor(DictionaryVehicleCapacityColor emailFolderType);

        [OperationContract]
        void InsertVehicleCapacityColor(DictionaryVehicleCapacityColor emailFolderType);

        [OperationContract]
        IEnumerable<DictionaryVehicleCapacityColor> GetVehicleCapacityColors();
    }

}
