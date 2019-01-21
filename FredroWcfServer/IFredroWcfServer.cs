using FredroWcfServer.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FredroWcfServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFredroWcfServer" in both code and config file together.
    [ServiceContract]
    public interface IFredroWcfServer
    {
        [OperationContract]
        BindingList<TheMessage> GetAllMessages();
    }
}
