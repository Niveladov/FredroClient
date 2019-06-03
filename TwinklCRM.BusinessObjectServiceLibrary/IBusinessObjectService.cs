using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectServiceLibrary
{
    [ServiceContract]
    public interface IBusinessObjectService : ICustomerService, IDealService, IPerformerSevice, IVehicleService,
                IDictionaryEmailFolderTypeService, IDictionaryEmailServerService, IDictionaryEmailServerParamService,
                IDictionaryHierarchyService, IDictionaryTripTypeService, IDictionaryVehicleTypeService
    {
    }
}
