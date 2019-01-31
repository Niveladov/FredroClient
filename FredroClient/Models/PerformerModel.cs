using FredroDAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class PerformerModel
    {
        public Performer CurrentPerformer { get; set; } = new Performer();

        public async Task Save()
        {
            try
            {
                throw new NotImplementedException();
                //using (var db = new PerformerContext())
                //{
                //    CurrentPerformer.IsDel = false;
                //    CurrentPerformer.CreatedBy = -1;
                //    CurrentPerformer.CreationDate = DateTime.Now;
                //    db.Performers.Add(CurrentPerformer);
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
