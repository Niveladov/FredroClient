using System;
using System.Collections.Generic;
using System.Linq;
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
}
