using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces
{
    internal interface ICustomer
    {
        Customer GetCustomer(int id);
        void DeleteCustomer(int id);
        void UpdateCustomer(Customer customer);
        void InsertCustomer(Customer customer);
        IEnumerable<Customer> GetAllCustomers();
    }

    [ServiceContract]
    public interface ICustomerService
    {
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
    }

}
