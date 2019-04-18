using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectServiceLibrary
{
    [ServiceContract]
    public interface IBusinessObjectService
    {
        [OperationContract]
        Performer GetPerformer(int id);
        [OperationContract]
        void DeletePerformer(int id);
        [OperationContract]
        void UpdatePerformer(Performer performer);
        [OperationContract]
        void InsertPerformer(Performer performer);

        [OperationContract]
        Deal GetDeal(int id);
        [OperationContract]
        void DeleteDeal(int id);
        [OperationContract]
        void UpdateDeal(Deal deal);
        [OperationContract]
        void InsertDeal(Deal deal);

        [OperationContract]
        Customer GetCustomer(int id);
        [OperationContract]
        void DeleteCustomer(int id);
        [OperationContract]
        void UpdateCustomer(Customer customer);
        [OperationContract]
        void InsertCustomer(Customer customer);

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
