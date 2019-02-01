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
using OpenPop.Pop3;
using OpenPop.Mime;

namespace FredroMailService.Models
{
    internal class EmailServerConnection : IMailServer
    {
        private const int MAIL_SERVER_ACCESS_PERIOD = 5000;
        private const string PLAIN_TEXT = "text/plain";
        private const string HTML_TEXT = "text/html";

        public HashSet<string> AllMailIds { get; private set; }
        
        public EmailServerConnection()
        {
            try
            {
                AllMailIds = new HashSet<string>();
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
            try
            {
                while (true)
                {
                    var allMails = GetAllMails();
                    if (allMails.Count > 0) OperationContext.Current.GetCallbackChannel<IMailCallback>().SendNewMails(allMails);
                    var allNewMails = new List<TheMail>();
                    foreach (var cachedEmailBox in SessionContext.Instance.CurrentUser.ChachedEmailBoxes)
                    {
                        var serverParams = cachedEmailBox.IncomingEmailServerParam;
                        var newMails = FetchNewMails(serverParams.Hostname, serverParams.Port, serverParams.UseSsl, 
                            SessionContext.Instance.CurrentUser.Login, SessionContext.Instance.CurrentUser.PasswordHash);
                        allNewMails.AddRange(newMails);
                        //foreach (var mailId in AllMailIds)
                        //{
                        //    if (!allMails.ContainsKey(mailId))
                        //    {
                        //        AllMailIds.Add(mailId);
                        //        allNewMails.Add(allMails[mailId]);
                        //    }
                        //}
                    }
                    if (allNewMails.Count > 0)
                    {
                        OperationContext.Current.GetCallbackChannel<IMailCallback>().SendNewMails(allNewMails);
                    }
                    Thread.Sleep(MAIL_SERVER_ACCESS_PERIOD);
                }
            }
            catch
            {
                throw;
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

        public void UpdateMail(TheMail mail)
        {
            using (var db = new FredroDbContext())
            {
                db.Entry(mail).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void InsertMail(TheMail mail)
        {
            using (var db = new FredroDbContext())
            {
                db.Mails.Add(mail);
                db.SaveChanges();
            }
        }

        private List<TheMail> GetAllMails()
        {
            var allMails = new List<TheMail>();
            using (var db = new FredroDbContext())
            {
                db.Mails.Load();
                allMails = db.Mails.Local.ToList();
            }
            return allMails;
        }

        private List<TheMail> FetchNewMails(string hostname, int port, bool useSsl, string username, string password)
        {
            try
            {
                // The client disconnects from the server when being disposed
                using (var client = new Pop3Client())
                {
                    // Connect to the server
                    client.Connect(hostname, port, useSsl);
                    // Authenticate ourselves towards the server
                    client.Authenticate(username, password);
                    // Get the number of messages in the inbox
                    var messageCount = client.GetMessageCount();
                    // We want to download all messages
                    var allMails = new List<TheMail>(messageCount);
                    // Messages are numbered in the interval: [1, messageCount]
                    // Ergo: message numbers are 1-based.
                    // Most servers give the latest message the highest number
                    for (int i = messageCount; i > 0; i--)
                    {
                        var message = client.GetMessage(i);
                        if (!AllMailIds.Contains(message.Headers.MessageId))
                        {
                            var mail = client.GetMessage(i).GetTheMail();
                            AllMailIds.Add(mail.Id);
                            allMails.Add(mail);
                            InsertMail(mail);
                        }
                    }
                    // Now return the fetched messages
                    return allMails;
                }
            }
            catch
            {
                throw;
            }
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
