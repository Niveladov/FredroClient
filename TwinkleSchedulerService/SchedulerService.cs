using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TwinkleDAL.Models.DatabaseObjectModels.Views;
using TwinkleSchedulerService.Models;

namespace TwinkleSchedulerService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class SchedulerService : ISchedulerService
    {
        private readonly ISchedulerDataManager _dataManager;
        
        public SchedulerService()
        {
            try
            {
                _dataManager = new SchedulerDataManager();
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
                throw new NotImplementedException();
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
