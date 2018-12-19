using FredroClient.Models.Contexts;
using FredroClient.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class NewPerformerModel
    {
        public Performer NewPerformer { get; set; } = new Performer();

        public async Task Save()
        {
            try
            {
                using (var db = new PerformerContext())
                {
                    NewPerformer.IsDel = false;
                    NewPerformer.CreatedBy = -1;
                    NewPerformer.CreationDate = DateTime.Now;
                    db.Performers.Add(NewPerformer);
                    await db.SaveChangesAsync();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
