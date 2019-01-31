using FredroDAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class CustomerModel
    {
        public Customer CurrentCustomer { get; set; } = new Customer();

        public async Task Save()
        {
            try
            {
                throw new NotImplementedException();
                //using (var db = new CustomerContext())
                //{
                //    CurrentCustomer.IsDel = false;
                //    CurrentCustomer.CreatedBy = -1;
                //    CurrentCustomer.CreationDate = DateTime.Now;
                //    db.Customers.Add(CurrentCustomer);
                //    await db.SaveChangesAsync();
                //}
            }
            catch
            {
                throw;
            }
        }
    }
}
