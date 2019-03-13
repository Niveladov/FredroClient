using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FredroDAL.Models.DatabaseObjectModels.Views;

namespace TwinkleSchedulerService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class SchedulerService : ISchedulerService
    {
        public IEnumerable<ViewVehicle> GetResources()
        {
            throw new NotImplementedException();
        }

        public void Join()
        {
            throw new NotImplementedException();
        }

        public void AssignAppointment(int appointmentId, int resourceId)
        {
            throw new NotImplementedException();
        }

        public void CancelAppointment(int appointmentId)
        {
            throw new NotImplementedException();
        }

        public void DeleteAppointment(int appointmentId)
        {
            throw new NotImplementedException();
        }

    }
}
