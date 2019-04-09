using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.BusinessObjectServiceLibrary;
using TwinklCRM.MailboxServiceLibrary;
using TwinklCRM.SchedulerServiceLibrary;

namespace TwinklCRM.ConsoleHostOfServices
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var mailServiceHost = new ServiceHost(typeof(MailboxService)))
            using (var schedulerServiceHost = new ServiceHost(typeof(SchedulerService)))
            using (var businessObjectServiceHost = new ServiceHost(typeof(BusinessObjectService)))
            {
                mailServiceHost.Credentials.ServiceCertificate.Certificate = new X509Certificate2("AppData\\MailboxServer.pfx");
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
