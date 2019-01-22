using FredroDAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FredroWcfServer
{
    [ServiceContract]
    public interface IFredroWcfServer
    {
        [OperationContract]
        IEnumerable<TheMessage> GetAllMessages();
    }
}
