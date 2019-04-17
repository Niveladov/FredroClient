using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.Client.BusinessObjectService;

namespace TwinklCRM.Client.Models
{
    internal sealed class CustomerModel
    {
        private readonly BusinessObjectServiceClient _boServiceClient;

        public Customer CurrentCustomer { get; }

        public CustomerModel(BusinessObjectServiceClient boServiceClient)
        {
            CurrentCustomer = new Customer();
            _boServiceClient = boServiceClient;
        }

        public void Save()
        {
            try
            {
                _boServiceClient.InsertCustomer(CurrentCustomer);
            }
            catch
            {
                throw;
            }
        }
    }
}
