using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwinkleSchedulerService.Models
{
    internal interface ISchedulerDeliveryManager
    {
        void Join();
    }

    internal sealed class SchedulerDeliveryManager : ISchedulerDeliveryManager
    {
        private const int DB_ACCESS_PERIOD = 5000;
        private readonly IDbDataManager _dataManager;
        private HashSet<string> _assignedAppointmentIds;
        private HashSet<string> _freeAppointmentIds;

        public SchedulerDeliveryManager(IDbDataManager dataManager)
        {
            _dataManager = dataManager;
            _assignedAppointmentIds = new HashSet<string>();
            _freeAppointmentIds = new HashSet<string>();
        }

        public void Join()
        {
            try
            {
                var assignedAppointments = _dataManager.GetAssignedAppointments().ToList();
                var freeAppointments = _dataManager.GetFreeAppointments().ToList();
                if (assignedAppointments.Count > 0)
                {
                    OperationContext.Current.GetCallbackChannel<ISchedulerCallback>()
                        .SendAssignedAppointments(assignedAppointments);
                }
                if(freeAppointments.Count > 0)
                {
                    OperationContext.Current.GetCallbackChannel<ISchedulerCallback>()
                        .SendFreeAppointments(freeAppointments);
                }
                //while (true)
                //{
                //    var allNewMails = new List<TheMail>();
                //    foreach (var cachedEmailBox in SessionContext.Instance.CurrentUser.ChachedEmailBoxes)
                //    {
                //        var serverParams = cachedEmailBox.IncomingEmailServerParam;
                //        var newMails = FetchNewMails(serverParams, cachedEmailBox);
                //        allNewMails.AddRange(newMails);
                //    }
                //    if (allNewMails.Count > 0)
                //    {
                //        OperationContext.Current.GetCallbackChannel<IMailCallback>().SendNewMails(allNewMails);
                //    }
                //    Thread.Sleep(DB_ACCESS_PERIOD);
                //}
            }
            catch
            {
                throw;
            }
        }

    }
}
