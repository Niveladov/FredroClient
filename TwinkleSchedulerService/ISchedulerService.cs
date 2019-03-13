using TwinkleDAL.Models.DatabaseObjectModels.Tables;
using TwinkleDAL.Models.DatabaseObjectModels.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TwinkleSchedulerService
{
    [ServiceContract(CallbackContract = typeof(ISchedulerCallback))]
    public interface ISchedulerService
    {
        /// <summary>
        /// subscribe to recieve appointments
        /// if any appoitment have been changed
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void Join();

        /// <summary>
        /// get all resources stored in database
        /// </summary>
        /// <returns>all existing resources stored in database</returns>
        [OperationContract]
        IEnumerable<ViewVehicle> GetResources();

        /// <summary>
        /// make the appointment assigned (set the resourceId to the appointment)
        /// </summary>
        /// <param name="appointmentId">id of appointment that will be assigned</param>
        /// <param name="resourceId">id of resource to which the appointment (from first param) will be assign</param>
        [OperationContract(IsOneWay = true)]
        void AssignAppointment(int appointmentId, int resourceId);

        /// <summary>
        /// make the appointment unassigned (clear the resourceId value in the appointment)
        /// </summary>
        /// <param name="appointmentId">id of appointment that will be canceled</param>
        [OperationContract(IsOneWay = true)]
        void CancelAppointment(int appointmentId);

        /// <summary>
        /// delete the appointment from database
        /// </summary>
        /// <param name="appointmentId">id of appointment that will be deleted</param>
        [OperationContract(IsOneWay = true)]
        void DeleteAppointment(int appointmentId);
    }

    internal interface ISchedulerCallback
    {
        /// <summary>
        /// send by callback all existing assigned (has the resource) 
        /// if any free appointment have been assigned
        /// </summary>
        /// <param name="assignedAppointments">there are all assigned appointments stored in database</param>
        [OperationContract(IsOneWay = true)]
        void SendAssignedAppointments(IEnumerable<ViewAssignedDeal> assignedAppointments);

        /// <summary>
        /// send by callback all existing not assigned (doesn't have the resource) 
        /// if any assigned appointment have been canceled or new appointment have been created
        /// </summary>
        /// <param name="freeAppointments">there are all not assigned appointments stored in database</param>
        [OperationContract(IsOneWay = true)]
        void SendFreeAppointments(IEnumerable<Deal> freeAppointments);
    }
}
