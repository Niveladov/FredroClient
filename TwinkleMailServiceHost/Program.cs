using TwinkleMailService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TwinkleSchedulerService;
using TwinklCRM.BusinessObjectService;

namespace TwinkleMailServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var mailServiceHost = new ServiceHost(typeof(MailService)))
            using (var schedulerServiceHost = new ServiceHost(typeof(SchedulerService)))
            using (var businessObjectServiceHost = new ServiceHost(typeof(BusinessObjectService)))
            {
                mailServiceHost.Open();
                Console.WriteLine("Mailbox service host started...");

                schedulerServiceHost.Open();
                Console.WriteLine("Scheduler service host started...");

                businessObjectServiceHost.Open();
                Console.WriteLine("Business object service host started...");

                Console.ReadLine();
            }
        }
    }
}
