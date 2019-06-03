using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces
{
    internal interface IPerformer
    {
        Performer GetPerformer(int id);
        void DeletePerformer(int id);
        void UpdatePerformer(Performer performer);
        void InsertPerformer(Performer performer);
        IEnumerable<Performer> GetAllPerformers();
    }

    [ServiceContract]
    public interface IPerformerSevice
    {
        [OperationContract]
        Performer GetPerformer(int id);

        [OperationContract]
        void DeletePerformer(int id);

        [OperationContract]
        void UpdatePerformer(Performer performer);

        [OperationContract]
        void InsertPerformer(Performer performer);

        [OperationContract]
        IEnumerable<Performer> GetAllPerformers();
    }

}
