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
        public Credentials Creds { get; }
        public List<TheMessage> AllMails { get; private set; }
        public List<IProtocol> MailSendingProtocols { get; }
        public List<IProtocol> MailReceivingProtocols { get; }
        
        public EmailServerConnection()
        {
            try
            {
                if (SessionContext.Instance.CurrentUser.ChachedEmailBoxes.Count != 0)
                {
                    MailSendingProtocols = new List<IProtocol>();
                    MailReceivingProtocols = new List<IProtocol>();
                    foreach (var chachedEmailBox in SessionContext.Instance.CurrentUser.ChachedEmailBoxes)
                    {
                        var emailServer = chachedEmailBox.EmailServer;
                        var popProtocol = new PopProtocol(emailServer.PopHostname, emailServer.PopPort, emailServer.PopUseSsl);
                        var smtpProtocol = new SmtpProtocol(emailServer.SmtpHostname, emailServer.SmtpPort, emailServer.SmtpUseSsl);
                        MailReceivingProtocols.Add(popProtocol);
                        MailSendingProtocols.Add(smtpProtocol);
                    }
                }
                else throw new Exception("User don't have presaved emails!");
            }
            catch
            {
                throw;
            }
        }
        
        public IEnumerable<TheMessage> GetAllMails()
        {
            using (var db = new FredroDbContext())
            {
                db.Messages.Load();
                AllMails = db.Messages.Local.ToList();
            }
            return AllMails;
        }

        public void RemoveMail(string Id)
        {
            throw new NotImplementedException();
        }

        public void SendMail(TheMessage message)
        {
            try
            {
                var currentMailBox = SessionContext.Instance.CurrentUser.ChachedEmailBoxes.Single(x => x.Id == 1/*message.ChachedEmailBoxId*/);
                MailAddress from = new MailAddress(message.FromAddress, message.FromDisplayName);
                MailAddress to = new MailAddress(message.ToAddress);
                MailMessage m = new MailMessage(from, to);

                //m.Attachments.Add(new Attachment("E://colors.txt"));
                m.Subject = message.Subject;
                m.Body = message.Body;
                m.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient(currentMailBox.EmailServer.SmtpHostname, currentMailBox.EmailServer.SmtpPort);
                smtpClient.Credentials = new NetworkCredential(currentMailBox.Login, currentMailBox.Password);
                smtpClient.EnableSsl = currentMailBox.EmailServer.SmtpUseSsl;
                smtpClient.Send(m);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateMail(TheMessage message)
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
        IEnumerable<TheMessage> GetAllMails();

        void SendMail(TheMessage message);

        void UpdateMail(TheMessage message);

        void RemoveMail(string Id);
    }
}
