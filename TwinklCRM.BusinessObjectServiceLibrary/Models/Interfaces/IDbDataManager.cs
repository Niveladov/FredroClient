using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces
{
    internal interface IDbDataManager : IPerformer, IDeal, ICustomer, IVehicle, 
        IDictionaryTripType, IDictionaryVehicleType, IDictionaryEmailFolderType, 
        IDictionaryEmailServer, IDictionaryEmailServerParam, IDictionaryHierarchy
    {
    }

}
