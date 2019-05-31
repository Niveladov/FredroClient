using System;
using System.Collections.Generic;
using System.Linq;
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
}
