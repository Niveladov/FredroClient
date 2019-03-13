using TwinkleMailService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TwinkleSchedulerService;

namespace TwinkleMailServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var mailServiceHost = new ServiceHost(typeof(MailService)))
            using (var schedulerServiceHost = new ServiceHost(typeof(SchedulerService)))
            {
                mailServiceHost.Open();
                Console.WriteLine("Mailbox service host started...");

                schedulerServiceHost.Open();
                Console.WriteLine("Scheduler service host started...");
                Console.ReadLine();
            }
        }
    }
}
