using FredroDAL.Models.Contexts;
using FredroDAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
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
            catch (ArgumentNullException ex)
            {
                throw new InvalidCredentialException("Authorize failed!", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidCredentialException("Authorize failed: user is not found!", ex);
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
