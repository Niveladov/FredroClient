using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ComponentModel;
using FredroDAL.Models.DatabaseObjectModels.Tables;
using FredroDAL.Models.Contexts;
using System.Data.Entity;

namespace FredroWcfServer
{
    public class FredroWcfServer : IFredroWcfServer
    {
        public IEnumerable<TheMessage> GetAllMessages()
        {
            List<TheMessage> messages = null;
            using (var db = new TheMessageContext())
            {
                db.Messages.Load();
                messages = db.Messages.Local.ToList();
            }
            return messages;
        }
    }
}
