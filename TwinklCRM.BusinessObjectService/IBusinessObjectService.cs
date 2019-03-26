using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectService
{
    [ServiceContract]
    public interface IBusinessObjectService
    {
        [OperationContract]
        Performer GetPerformer(int id);
        [OperationContract]
        void DeletePerformer(int id);
        [OperationContract]
        void UpdatePerformer(int id);
        [OperationContract]
        void InsertPerformer(Performer performer);

        [OperationContract]
        Deal GetDeal(int id);
        [OperationContract]
        void DeleteDeal(int id);
        [OperationContract]
        void UpdateDeal(int id);
        [OperationContract]
        void InsertDeal(Deal deal);

        [OperationContract]
        IEnumerable<Customer> GetAllCustomers();
        [OperationContract]
        IEnumerable<Performer> GetAllPerformers();
        [OperationContract]
        IEnumerable<Vehicle> GetAllVehicles();
        [OperationContract]
        IEnumerable<DictionaryTripType> GetAllTripTypes();
        
    }
}
