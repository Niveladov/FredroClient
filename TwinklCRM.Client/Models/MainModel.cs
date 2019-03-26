using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.Client.BusinessObjectService;

namespace TwinklCRM.Client.Models
{
    internal sealed class MainModel
    {
        public BusinessObjectServiceClient BOServiceClient { get; }

        public MainModel()
        {
            BOServiceClient = new BusinessObjectServiceClient("NetTcpBinding_IBusinessObjectService");
        }


    }
}
