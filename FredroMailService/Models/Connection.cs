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
using System.Text;
using System.Threading.Tasks;

namespace FredroMailService.Models
{
    internal class EmailServerConnection : IMailServer
    {
        public Credentials Creds { get; }
        public List<TheMessage> AllMails { get; private set; }
        public IProtocol MailSendingProtocol { get; }
        public IProtocol MailReceivingProtocol { get; }
        
        public EmailServerConnection(Credentials creds)
        {
            Creds = creds;
            var protocols = Server.Gmail.GetServerSettings();
            MailSendingProtocol = protocols.OfType<SmtpProtocol>().Single();
            MailReceivingProtocol = protocols.OfType<PopProtocol>().Single();
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

        public async Task RemoveMailAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public void SendMail(TheMessage message)
        {
            try
            {
                MailAddress from = new MailAddress(message.FromAddress, message.FromDisplayName);
                MailAddress to = new MailAddress(message.ToAddress);
                MailMessage m = new MailMessage(from, to);

                //m.Attachments.Add(new Attachment("E://colors.txt"));
                m.Subject = message.Subject;
                m.Body = message.Body;
                m.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient(MailSendingProtocol.Hostname, MailSendingProtocol.Port);
                smtpClient.Credentials = new NetworkCredential(Creds.Login, Creds.Password);
                smtpClient.EnableSsl = MailSendingProtocol.UseSsl;
                smtpClient.Send(m);
            }
            catch
            {
                throw;
            }
        }

        public async Task SendMailAsync(TheMessage message)
        {
            try
            {
                MailAddress from = new MailAddress(message.FromAddress, message.FromDisplayName);
                MailAddress to = new MailAddress(message.ToAddress);
                MailMessage m = new MailMessage(from, to);

                //m.Attachments.Add(new Attachment("E://colors.txt"));
                m.Subject = message.Subject;
                m.Body = message.Body;
                m.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient(MailSendingProtocol.Hostname, MailSendingProtocol.Port);
                smtpClient.Credentials = new NetworkCredential(Creds.Login, Creds.Password);
                smtpClient.EnableSsl = MailSendingProtocol.UseSsl;
                await smtpClient.SendMailAsync(m);
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

        public async Task UpdateMailAsync(TheMessage message)
        {
            using (var db = new FredroDbContext())
            {
                db.Entry(message).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }
    }

    internal interface IMailServer
    {
        IEnumerable<TheMessage> GetAllMails();

        void SendMail(TheMessage message);

        Task SendMailAsync(TheMessage message);

        void UpdateMail(TheMessage message);

        Task UpdateMailAsync(TheMessage message);

        void RemoveMail(string Id);

        Task RemoveMailAsync(string Id);
    }
}
