using FredroDAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroMailService.ExtraClasses
{
    internal sealed class SessionContext
    {
        private static SessionContext _instance;
        public static SessionContext Instance { get { return _instance; } }
        public User CurrentUser { get; }

        private SessionContext(string login, string password)
        {
            //CurrentUser = new User();
        }
        public static void CreateInstance(string login, string password)
        {
            if (_instance == null) _instance = new SessionContext(login, password);
        }
    }
}
