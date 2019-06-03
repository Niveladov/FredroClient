using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces
{
    internal interface IDeal
    {
        Deal GetDeal(int id);
        void DeleteDeal(int id);
        void UpdateDeal(Deal deal);
        void InsertDeal(Deal deal);
        IEnumerable<Deal> GetAllDeals();
    }

    [ServiceContract]
    public interface IDealService
    {
        [OperationContract]
        Deal GetDeal(int id);

        [OperationContract]
        void DeleteDeal(int id);

        [OperationContract]
        void UpdateDeal(Deal deal);

        [OperationContract]
        void InsertDeal(Deal deal);

        [OperationContract]
        IEnumerable<Deal> GetAllDeals();
    }
}
