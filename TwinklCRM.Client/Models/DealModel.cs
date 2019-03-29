using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Threading.Tasks;
using TwinklCRM.Client.BusinessObjectService;

namespace TwinklCRM.Client.Models
{
    internal sealed class DealModel
    {
        private readonly BusinessObjectServiceClient _boServiceClient;

        public Deal CurrentDeal { get; }


        public DealModel(BusinessObjectServiceClient boServiceClient)
        {
            _boServiceClient = boServiceClient;
            CurrentDeal = new Deal();
        }

        public DealModel(BusinessObjectServiceClient boServiceClient, Deal deal)
        {
            _boServiceClient = boServiceClient;
            CurrentDeal = deal;
        }


        public void Save()
        {
            try
            {
                _boServiceClient.InsertDeal(CurrentDeal);
            }
            catch
            {
                throw;
            }
        }
    }
}
