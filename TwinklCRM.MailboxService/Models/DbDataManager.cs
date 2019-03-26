using TwinklCRM.DAL.Models.Contexts;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.MailboxServiceLibrary.ExtraClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.MailboxServiceLibrary.Models
{
    internal interface IDbDataManager
    {
        void InsertMail(TheMail mail);
        void UpdateMail(TheMail mail);
        void RemoveMail(string id);
        List<TheMail> GetUserMails();
        IEnumerable<CachedEmailBox> GetUserEmailBoxes();
    }

    internal sealed class DbDataManager : IDbDataManager
    {
        public void InsertMail(TheMail mail)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Mails.Add(mail);
                db.SaveChanges();
            }
        }

        public void UpdateMail(TheMail mail)
        {
            using (var db = new TwinkleDbContext())
            {
                db.Entry(mail).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void RemoveMail(string id)
        {
            using (var db = new TwinkleDbContext())
            {
                var mail = db.Mails.Find(id);
                db.Mails.Remove(mail);
                db.SaveChanges();
            }
        }

        public List<TheMail> GetUserMails()
        {
            var allMails = new List<TheMail>();
            using (var db = new TwinkleDbContext())
            {
                db.Mails.Load();
                var userEmailBoxIds = SessionContext.Instance.CurrentUser.ChachedEmailBoxes.Select(box => box.Id.Value).ToList();
                allMails = db.Mails.Where(mail => 
                    userEmailBoxIds.Contains(mail.ChachedEmailBoxId.Value)).ToList();
            }
            return allMails;
        }

        public IEnumerable<CachedEmailBox> GetUserEmailBoxes()
        {
            return SessionContext.Instance.CurrentUser.ChachedEmailBoxes;
        }

    }
}
