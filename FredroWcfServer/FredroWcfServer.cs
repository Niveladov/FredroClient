using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FredroWcfServer.Models.DatabaseObjectModels.Tables;
using System.ComponentModel;
using FredroWcfServer.Models.Contexts;
using System.Data.Entity;

namespace FredroWcfServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FredroWcfServer" in both code and config file together.
    public class FredroWcfServer : IFredroWcfServer
    {
        public BindingList<TheMessage> GetAllMessages()
        {
            BindingList<TheMessage> messages = null;
            using (var db = new TheMessageContext())
            {
                db.Messages.Load();
                messages = db.Messages.Local.ToBindingList();
            }
            return messages;
        }
    }
}
