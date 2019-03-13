using TwinkleDAL.Models.Contexts;
using TwinkleDAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace TwinkleMailService.ExtraClasses
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
                using (var db = new TwinkleDbContext())
                {
                    CurrentUser = db.Users.Include(x => x.ChachedEmailBoxes.Select(s => s.IncomingEmailServerParam))
                                          .Include(x => x.ChachedEmailBoxes.Select(s => s.OutgoingEmailServerParam))
                                          .Include(x => x.ChachedEmailBoxes.Select(s => s.EmailServer))
                                          .Include(x => x.ChachedEmailBoxes.Select(s => s.User))
                                          .Single(t => t.Login == login && t.PasswordHash == password);

                    //CurrentUser = db.Users.Include(x => x.ChachedEmailBoxes.Select( s => s.IncomingEmailServerParam))
                    //            .Single(t => t.Login == login && t.PasswordHash == password);
                    //db.Entry(CurrentUser).Collection(nameof(CurrentUser.ChachedEmailBoxes)).Load();
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
