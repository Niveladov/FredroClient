﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        private const int DB_ACCESS_PERIOD = 5000;
        private readonly IDbDataManager _dataManager;
        private HashSet<long> _assignedAppointmentIds;
        private HashSet<long> _freeAppointmentIds;

        public SchedulerDeliveryManager(IDbDataManager dataManager)
        {
            _dataManager = dataManager;
            _assignedAppointmentIds = new HashSet<long>();
            _freeAppointmentIds = new HashSet<long>();
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
            if (!_assignedAppointmentIds.SetEquals(assignedAppointmentIds))
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

        private HashSet<long> GetAssignedAppointmentIds(List<ViewAssignedDeal> assignedAppointments)
        {
            var set = new HashSet<long>();
            foreach (var appointment in assignedAppointments)
            {
                set.Add(appointment.Id.Value);
            }
            return set;
        }

        private HashSet<long> GetFreeAppointmentIds(List<Deal> freeAppointments)
        {
            var set = new HashSet<long>();
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
