using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.Client.BusinessObjectService;

namespace TwinklCRM.Client.Models
{
    internal sealed class PerformerModel
    {
        private readonly BusinessObjectServiceClient _boServiceClient;

        public Performer CurrentPerformer { get; }

        public PerformerModel(BusinessObjectServiceClient boServiceClient)
        {
            CurrentPerformer = new Performer();
            _boServiceClient = boServiceClient;
        }

        public void Save()
        {
            try
            {
                _boServiceClient.InsertPerformer(CurrentPerformer);
            }
            catch
            {
                throw;
            }
        }
    }
}
