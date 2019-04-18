using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TwinklCRM.BaseFunctionsLibrary.Collections;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Views;

namespace TwinklCRM.SchedulerServiceLibrary.Models
{
    internal interface ISchedulerDeliveryManager
    {
        void Join();
    }

    internal sealed class SchedulerDeliveryManager : ISchedulerDeliveryManager
    {
        private const int DB_ACCESS_PERIOD = 100;
        private readonly IDbDataManager _dataManager;
        private Dictionary<int, int> _assignedAppointmentIds;
        private HashSet<int> _freeAppointmentIds;

        public SchedulerDeliveryManager(IDbDataManager dataManager)
        {
            _dataManager = dataManager;
            _assignedAppointmentIds = new Dictionary<int, int>();
            _freeAppointmentIds = new HashSet<int>();
        }

        public void Join()
        {
            try
            {
                while (true)
                {
                    RefreshAssignedAppointments();
                    RefreshFreeAppointments();
                    Thread.Sleep(DB_ACCESS_PERIOD);
                }
            }
            catch
            {
                throw;
            }
        }

        private void RefreshAssignedAppointments()
        {
            var assignedAppointments = GetAssignedAppointments();
            var assignedAppointmentIds = GetAssignedAppointmentIds(assignedAppointments);
            if (!_assignedAppointmentIds.IsEqual(assignedAppointmentIds))
            {
                _assignedAppointmentIds = assignedAppointmentIds;
                SendAssignedAppointments(assignedAppointments);
            }
        }

        private void RefreshFreeAppointments()
        {
            var freeAppointments = GetFreeAppointments();
            var freeAppointmentIds = GetFreeAppointmentIds(freeAppointments);
            if (!_freeAppointmentIds.SetEquals(freeAppointmentIds))
            {
                _freeAppointmentIds = freeAppointmentIds;
                SendFreeAppointments(freeAppointments);
            }
        }

        private List<ViewAssignedDeal> GetAssignedAppointments()
        {
            return _dataManager.GetAssignedAppointments().ToList();
        }

        private List<Deal> GetFreeAppointments()
        {
            return _dataManager.GetFreeAppointments().ToList();
        }

        private Dictionary<int, int> GetAssignedAppointmentIds(List<ViewAssignedDeal> assignedAppointments)
        {
            var dictionary = new Dictionary<int, int>();
            foreach (var appointment in assignedAppointments)
            {
                dictionary.Add(appointment.Id.Value, appointment.VehicleId.Value);
            }
            return dictionary;
        }

        private HashSet<int> GetFreeAppointmentIds(List<Deal> freeAppointments)
        {
            var set = new HashSet<int>();
            foreach (var appointment in freeAppointments)
            {
                set.Add(appointment.Id.Value);
            }
            return set;
        }

        private void SendAssignedAppointments(List<ViewAssignedDeal> assignedAppointments)
        {
            if (assignedAppointments.Count > 0)
            {
                OperationContext.Current.GetCallbackChannel<ISchedulerCallback>()
                    .SendAssignedAppointments(assignedAppointments);
            }
        }

        private void SendFreeAppointments(List<Deal> freeAppointments)
        {
            if (freeAppointments.Count > 0)
            {
                OperationContext.Current.GetCallbackChannel<ISchedulerCallback>()
                    .SendFreeAppointments(freeAppointments);
            }
        }

    }
}
