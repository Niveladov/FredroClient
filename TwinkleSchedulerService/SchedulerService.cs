using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Views;
using TwinklCRM.SchedulerService.Models;

namespace TwinklCRM.SchedulerService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class SchedulerService : ISchedulerService
    {
        private readonly IDbDataManager _dataManager;
        private readonly ISchedulerDeliveryManager _deliveryManager;

        public SchedulerService()
        {
            try
            {
                _dataManager = new DbDataManager();
                _deliveryManager = new SchedulerDeliveryManager(_dataManager);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<ViewVehicle> GetResources()
        {
            try
            {
                return _dataManager.GetResources();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void Join()
        {
            try
            {
                _deliveryManager.Join();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void AssignAppointment(int appointmentId, int resourceId)
        {
            try
            {
                _dataManager.AssignAppointment(appointmentId, resourceId);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void CancelAppointment(int appointmentId)
        {
            try
            {
                _dataManager.CancelAppointment(appointmentId);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteAppointment(int appointmentId)
        {
            try
            {
                _dataManager.DeleteAppointment(appointmentId);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

    }
}
