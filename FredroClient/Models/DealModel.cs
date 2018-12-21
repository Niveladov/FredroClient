using FredroClient.Models.Contexts;
using FredroClient.Models.DatabaseObjectModels.Tables;
using FredroClient.Models.DatabaseObjectModels.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class DealModel
    {
        public Deal CurrentDeal { get; set; }

        public async Task Save()
        {
            try
            {
                using (var db = new DealContext())
                {
                    CurrentDeal.CreatedBy = -1;
                    CurrentDeal.CreationDate = DateTime.Now;
                    db.Deals.Add(CurrentDeal);
                    await db.SaveChangesAsync();
                }
            }
            catch
            {
                throw;
            }
        }
        public DealModel()
        {
            CurrentDeal = new Deal();
        }

        public DealModel(Deal deal)
        {
            CurrentDeal = deal;
        }
    }
}
