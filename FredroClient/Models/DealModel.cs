using FredroDAL.Models.DatabaseObjectModels.Tables;
using System;
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
                throw new NotImplementedException();
                //using (var db = new DealContext())
                //{
                //    CurrentDeal.CreatedBy = -1;
                //    CurrentDeal.CreationDate = DateTime.Now;
                //    db.Deals.Add(CurrentDeal);
                //    await db.SaveChangesAsync();
                //}
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
