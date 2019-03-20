using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinkleClient.BusinessObjectService;

namespace TwinkleClient.Models
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
