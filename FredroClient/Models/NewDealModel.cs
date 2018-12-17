using FredroClient.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class NewDealModel
    {
        public Deal NewDeal { get; set; } = new Deal();

        public async void Save()
        {
            try
            {
                using (var db = new DealContext())
                {
                    NewDeal.CreatedBy = -1;
                    NewDeal.CreationDate = DateTime.Now;
                    db.Deals.Add(NewDeal);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
