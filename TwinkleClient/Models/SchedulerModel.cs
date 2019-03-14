using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Remoting;
using System.ServiceModel;
using TwinkleClient.ExtraClasses;
using TwinkleClient.SchedulerService;
using TwinkleDAL.Models.DatabaseObjectModels.Tables;
using TwinkleDAL.Models.DatabaseObjectModels.Views;

namespace TwinkleClient.Models
{
    internal sealed class SchedulerModel : ISchedulerServiceCallback
    {
        private bool _isJoined = false;
        private SchedulerServiceClient _serviceClient { get; }

        public List<ViewVehicle> Resources { get; }
        public ObservableCollection<ViewAssignedDeal> AssignedAppointments { get; }
        public ObservableCollection<Deal> FreeAppointments { get; }
        
        //public event EventHandler OnReloadingAssignedAppointments;
        //public event EventHandler OnReloadingFreeAppointments;

        public SchedulerModel()
        {
            Resources = new List<ViewVehicle>();
            AssignedAppointments = new ObservableCollection<ViewAssignedDeal>();
            FreeAppointments = new ObservableCollection<Deal>();
            var instanceContext = new InstanceContext(this);
            _serviceClient = new SchedulerServiceClient(instanceContext, "NetTcpBinding_ISchedulerService");
        }

        public void JoinToServer()
        {
            try
            {
                if (!_isJoined)
                {
                    LoadResources();
                    _serviceClient.Join();
                    _isJoined = true;
                }
            }
            catch (TimeoutException ex)
            {
                //FredroMessageBox.ShowError($"Timeout error: {ex.Message}");
                _serviceClient.Abort();
                throw new ServerException("Возникла внутрення ошибка сервера. Timeout error.", ex);
            }
            catch (FaultException ex)
            {
                //FredroMessageBox.ShowError(ex.Message + ex.Code.Name);
                _serviceClient.Abort();
                throw new ServerException("Возникла внутрення ошибка сервера.", ex);
            }
            catch (CommunicationException ex)
            {
                //FredroMessageBox.ShowError($"Communication error: {ex.Message}");
                _serviceClient.Abort();
                throw new ServerException("Возникла внутрення ошибка сервера. Communication error.", ex);
            }
        }

        private void LoadResources()
        {
            try
            {
                Resources.Clear();
                var resources = _serviceClient.GetResources();
                Resources.AddRange(resources);
            }
            catch (FaultException ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
                _serviceClient.Abort();
            }
        }
        
        public void AssignAppointment(int appointmentId, int resourceId)
        {
            try
            {
                _serviceClient.AssignAppointment(appointmentId, resourceId);
            }
            catch (FaultException ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
                _serviceClient.Abort();
            }
        }

        public void CancelAppointment(int appointmentId)
        {
            try
            {
                _serviceClient.CancelAppointment(appointmentId);
            }
            catch (FaultException ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
                _serviceClient.Abort();
            }
        }

        public void DeleteAppointment(int appointmentId)
        {
            try
            {
                _serviceClient.DeleteAppointment(appointmentId);
            }
            catch (FaultException ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
                _serviceClient.Abort();
            }
        }
        
        //public Deal GetDeal()
        //{
        //    try
        //    {
        //        return ServiceClient.GetDeal();
        //    }
        //    catch (FaultException ex)
        //    {
        //        TwinkleMessageBox.ShowError(ex.Message);
        //        ServiceClient.Abort();
        //    }
        //}


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
