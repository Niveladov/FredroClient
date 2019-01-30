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

namespace FredroMailService.Models
{
    internal class EmailServerConnection : IMailServer
    {
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
        
        public IEnumerable<TheMail> GetAllMails()
        {
            using (var db = new FredroDbContext())
            {
                db.Mails.Load();
                AllMails = db.Mails.Local.ToList();
            }
            return AllMails;
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

    }

    internal interface IMailServer
    {
        IEnumerable<TheMail> GetAllMails();

        void SendMail(TheMail mail);

        void UpdateMail(TheMail mail);

        void RemoveMail(string Id);
    }
}
