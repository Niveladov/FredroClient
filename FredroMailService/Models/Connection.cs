using FredroDAL.Models.Contexts;
using FredroDAL.Models.DatabaseObjectModels.Tables;
using FredroDAL.Models;
using FredroMailService.ExtraClasses;
using FredroMailService.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.ServiceModel;
using System.Threading;

namespace FredroMailService.Models
{
    internal class EmailServerConnection : IMailServer
    {
        private const int MAIL_SERVER_ACCESS_PERIOD = 5000;

        public List<TheMail> AllMails { get; private set; }
        
        public EmailServerConnection()
        {
            try
            {
                if (SessionContext.Instance.CurrentUser.ChachedEmailBoxes.Count == 0)
                {
                    throw new Exception("User don't have presaved emails!");
                }
            }
            catch
            {
                throw;
            }
        }

        public void Join()
        {
            while (true)
            {
                var mails = GetAllMails();
                if (AllMails != mails) OperationContext.Current.GetCallbackChannel<IMailCallback>().RefreshMails(mails);
                Thread.Sleep(MAIL_SERVER_ACCESS_PERIOD);
            }
        }

        public void RemoveMail(string Id)
        {
            throw new NotImplementedException();
        }

        public void SendMail(TheMail mail)
        {
            try
            {
                var currentMailBox = SessionContext.Instance.CurrentUser.ChachedEmailBoxes.Single(x => x.Id == mail.ChachedEmailBoxId);
                var currentOutgoingParam = currentMailBox.OutgoingEmailServerParam;
                MailAddress from = new MailAddress(mail.FromAddress, mail.FromDisplayName);
                MailAddress to = new MailAddress(mail.ToAddress);
                MailMessage m = new MailMessage(from, to);

                //m.Attachments.Add(new Attachment("E://colors.txt"));
                m.Subject = mail.Subject;
                m.Body = mail.Body;
                m.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient(currentOutgoingParam.Hostname, currentOutgoingParam.Port);
                smtpClient.Credentials = new NetworkCredential(currentMailBox.Login, currentMailBox.Password);
                smtpClient.EnableSsl = currentOutgoingParam.UseSsl;
                smtpClient.Send(m);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateMail(TheMail message)
        {
            using (var db = new FredroDbContext())
            {
                db.Entry(message).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private IEnumerable<TheMail> GetAllMails()
        {
            using (var db = new FredroDbContext())
            {
                db.Mails.Load();
                AllMails = db.Mails.Local.ToList();
            }
            return AllMails;
        }
    }

    internal interface IMailServer
    {
        void Join();

        void SendMail(TheMail mail);

        void UpdateMail(TheMail mail);

        void RemoveMail(string Id);
    }

}
