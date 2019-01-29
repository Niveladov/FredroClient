using FredroDAL.Models.Contexts;
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
            try
            {
                using (var db = new FredroDbContext())
                {
                    CurrentUser = db.Users.Single(x => x.Login == login && x.PasswordHash == password);
                }
            }
            catch (ArgumentNullException)
            {
                throw new Exception("Authorize failed: username or password is empty!");
            }
            catch (InvalidOperationException)
            {
                throw new Exception("Authorize failed: user is not found!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CreateInstance(string login, string password)
        {
            try
            {
                if (_instance == null) _instance = new SessionContext(login, password);
            }
            catch
            {
                throw;
            }
        }

    }
}
