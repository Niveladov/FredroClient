using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces
{
    internal interface IVehicle
    {
        Vehicle GetVehicle(int id);
        void DeleteVehicle(int id);
        void UpdateVehicle(Vehicle vehicle);
        void InsertVehicle(Vehicle vehicle);
        IEnumerable<Vehicle> GetAllVehicles();
    }

    [ServiceContract]
    public interface IVehicleService
    {
        [OperationContract]
        Vehicle GetVehicle(int id);

        [OperationContract]
        void DeleteVehicle(int id);

        [OperationContract]
        void UpdateVehicle(Vehicle vehicle);

        [OperationContract]
        void InsertVehicle(Vehicle vehicle);

        [OperationContract]
        IEnumerable<Vehicle> GetAllVehicles();
    }
}
