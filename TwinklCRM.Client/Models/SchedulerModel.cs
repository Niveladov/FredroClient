using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Remoting;
using System.ServiceModel;
using TwinklCRM.Client.BusinessObjectService;
using TwinklCRM.Client.ExtraClasses;
using TwinklCRM.Client.SchedulerService;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Views;

namespace TwinklCRM.Client.Models
{
    internal sealed class SchedulerModel : ISchedulerServiceCallback
    {
        private bool _isJoined = false;
        private SchedulerServiceClient _schedulerServiceClient;
        public BusinessObjectServiceClient BOServiceClient { get; }

        public List<ViewVehicle> Resources { get; }
        public ObservableCollection<ViewAssignedDeal> AssignedAppointments { get; }
        public ObservableCollection<Deal> FreeAppointments { get; }
        
        //public event EventHandler OnReloadingAssignedAppointments;
        //public event EventHandler OnReloadingFreeAppointments;

        public SchedulerModel(BusinessObjectServiceClient boServiceClient)
        {
            Resources = new List<ViewVehicle>();
            AssignedAppointments = new ObservableCollection<ViewAssignedDeal>();
            FreeAppointments = new ObservableCollection<Deal>();
            var instanceContext = new InstanceContext(this);
            _schedulerServiceClient = new SchedulerServiceClient(instanceContext, "NetTcpBinding_ISchedulerService");
            BOServiceClient = boServiceClient;
        }

        public void JoinToServer()
        {
            try
            {
                if (!_isJoined)
                {
                    LoadResources();
                    _schedulerServiceClient.Join();
                    _isJoined = true;
                }
            }
            catch (TimeoutException ex)
            {
                //FredroMessageBox.ShowError($"Timeout error: {ex.Message}");
                _schedulerServiceClient.Abort();
                throw new ServerException("Возникла внутрення ошибка сервера. Timeout error.", ex);
            }
            catch (FaultException ex)
            {
                //FredroMessageBox.ShowError(ex.Message + ex.Code.Name);
                _schedulerServiceClient.Abort();
                throw new ServerException("Возникла внутрення ошибка сервера.", ex);
            }
            catch (CommunicationException ex)
            {
                //FredroMessageBox.ShowError($"Communication error: {ex.Message}");
                _schedulerServiceClient.Abort();
                throw new ServerException("Возникла внутрення ошибка сервера. Communication error.", ex);
            }
        }

        private void LoadResources()
        {
            try
            {
                Resources.Clear();
                var resources = _schedulerServiceClient.GetResources();
                Resources.AddRange(resources);
            }
            catch (FaultException ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
                _schedulerServiceClient.Abort();
            }
        }
        
        public void AssignAppointment(int appointmentId, int resourceId)
        {
            try
            {
                _schedulerServiceClient.AssignAppointment(appointmentId, resourceId);
            }
            catch (FaultException ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
                _schedulerServiceClient.Abort();
            }
        }

        public void CancelAppointment(int appointmentId)
        {
            try
            {
                _schedulerServiceClient.CancelAppointment(appointmentId);
            }
            catch (FaultException ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
                _schedulerServiceClient.Abort();
            }
        }

        public void DeleteAppointment(int appointmentId)
        {
            try
            {
                _schedulerServiceClient.DeleteAppointment(appointmentId);
            }
            catch (FaultException ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
                _schedulerServiceClient.Abort();
            }
        }

        public Deal GetDeal(int id)
        {
            try
            {
                return BOServiceClient.GetDeal(id);
            }
            catch (FaultException ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
                BOServiceClient.Abort();
                return null;
            }
        }


        public void SendAssignedAppointments(ViewAssignedDeal[] assignedAppointments)
        {
            AssignedAppointments.Clear();
            foreach (var appt in assignedAppointments)
            {
                AssignedAppointments.Add(appt);
            }
        }

        public void SendFreeAppointments(Deal[] freeAppointments)
        {
            FreeAppointments.Clear();
            foreach(var appt in freeAppointments)
            {
                FreeAppointments.Add(appt);
            }
        }

    }
}
