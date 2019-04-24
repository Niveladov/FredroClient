using TwinklCRM.DAL.Models.Contexts;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models;
using TwinklCRM.MailboxServiceLibrary.ExtraClasses;
using TwinklCRM.MailboxServiceLibrary.Models.Enums;
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
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;
using System.Threading.Tasks;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;
using TwinklCRM.BaseFunctionsLibrary.Collections;

namespace TwinklCRM.MailboxServiceLibrary.Models
{
    internal interface IMailDeliveryManager
    {
        void Join();
    }

    internal class EmailDeliveryManager : IMailDeliveryManager
    {
        private const int MAIL_SERVER_ACCESS_PERIOD = 5000;
        private IDbDataManager _dbDataManager;

        private HashSet<string> _inboxMailIds;
        private HashSet<string> _outboxMailIds;
        private HashSet<string> _spamMailIds;
        private HashSet<string> _deletedMailIds;

        public EmailDeliveryManager(IDbDataManager dbDataManager)
        {
            try
            {
                _inboxMailIds = new HashSet<string>();
                _outboxMailIds = new HashSet<string>();
                _spamMailIds = new HashSet<string>();
                _deletedMailIds = new HashSet<string>();
                if (SessionContext.Instance.CurrentUser.ChachedEmailBoxes.Count == 0)
                {
                    throw new Exception("User don't have presaved emails!");
                }
                else
                {
                    _dbDataManager = dbDataManager;
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
                var allStoredMails = _dbDataManager.GetUserMails();
                var allStoredEmails = GetEmails(allStoredMails);

                if (allStoredEmails.InboxEmails.Count > 0)
                {
                    OperationContext.Current.GetCallbackChannel<IMailboxCallback>().SendNewInboxMails(allStoredEmails.InboxEmails);
                    InitMailIds(allStoredEmails.InboxEmails, EmailFolderType.Inbox);
                }
                if (allStoredEmails.OutboxEmails.Count > 0)
                {
                    OperationContext.Current.GetCallbackChannel<IMailboxCallback>().SendNewOutboxMails(allStoredEmails.OutboxEmails);
                    InitMailIds(allStoredEmails.OutboxEmails, EmailFolderType.Outbox);
                }
                if (allStoredEmails.SpamEmails.Count > 0)
                {
                    OperationContext.Current.GetCallbackChannel<IMailboxCallback>().SendNewSpamMails(allStoredEmails.SpamEmails);
                    InitMailIds(allStoredEmails.SpamEmails, EmailFolderType.Spam);
                }
                if (allStoredEmails.DeletedEmails.Count > 0)
                {
                    OperationContext.Current.GetCallbackChannel<IMailboxCallback>().SendNewDeletedMails(allStoredEmails.DeletedEmails);
                    InitMailIds(allStoredEmails.DeletedEmails, EmailFolderType.Deleted);
                }

                while (true)
                {
                    var allNewMails = new Emails();
                    foreach (var cachedEmailBox in SessionContext.Instance.CurrentUser.ChachedEmailBoxes)
                    {
                        var serverParams = cachedEmailBox.IncomingEmailServerParam;
                        var newEmails = FetchNewEmails(serverParams, cachedEmailBox);

                        if (newEmails.InboxEmails.Count > 0)
                        {
                            allNewMails.InboxEmails.AddRange(newEmails.InboxEmails);
                            Task.Run(() => InsertMails(newEmails.InboxEmails)); //think about it
                        }
                        if (newEmails.OutboxEmails.Count > 0)
                        {
                            allNewMails.OutboxEmails.AddRange(newEmails.OutboxEmails);
                            Task.Run(() => InsertMails(newEmails.OutboxEmails)); //think about it
                        }
                        if (newEmails.DeletedEmails.Count > 0)
                        {
                            allNewMails.DeletedEmails.AddRange(newEmails.DeletedEmails);
                            Task.Run(() => InsertMails(newEmails.DeletedEmails)); //think about it
                        }
                        if (newEmails.SpamEmails.Count > 0)
                        {
                            allNewMails.SpamEmails.AddRange(newEmails.SpamEmails);
                            Task.Run(() => InsertMails(newEmails.SpamEmails)); //think about it
                        }
                    }
                    
                    if (allNewMails.InboxEmails.Count > 0)
                    {
                        OperationContext.Current.GetCallbackChannel<IMailboxCallback>().SendNewInboxMails(allNewMails.InboxEmails);
                    }
                    if (allNewMails.OutboxEmails.Count > 0)
                    {
                        OperationContext.Current.GetCallbackChannel<IMailboxCallback>().SendNewOutboxMails(allNewMails.OutboxEmails);
                    }
                    if (allNewMails.SpamEmails.Count > 0)
                    {
                        OperationContext.Current.GetCallbackChannel<IMailboxCallback>().SendNewSpamMails(allNewMails.SpamEmails);
                    }
                    if (allNewMails.DeletedEmails.Count > 0)
                    {
                        OperationContext.Current.GetCallbackChannel<IMailboxCallback>().SendNewDeletedMails(allNewMails.DeletedEmails);
                    }

                    Thread.Sleep(MAIL_SERVER_ACCESS_PERIOD);
                }
            }
            catch
            {
                throw;
            }
        }

        private Emails GetEmails(List<TheMail> mails)
        {
            var emails = new Emails();
            var inboxMails = mails.Where(x => x.EmailFolderTypeId == (int)EmailFolderType.Inbox);
            var outboxMails = mails.Where(x => x.EmailFolderTypeId == (int)EmailFolderType.Outbox);
            var spamMails = mails.Where(x => x.EmailFolderTypeId == (int)EmailFolderType.Spam);
            var deletedMails = mails.Where(x => x.EmailFolderTypeId == (int)EmailFolderType.Deleted);
            emails.InboxEmails.AddRange(inboxMails);
            emails.OutboxEmails.AddRange(outboxMails);
            emails.SpamEmails.AddRange(spamMails);
            emails.DeletedEmails.AddRange(deletedMails);
            return emails;
        }

        private void InitMailIds(IEnumerable<TheMail> mails, EmailFolderType folderType)
        {
            var mailIds = GetMailIds(folderType);
            foreach (var mail in mails)
            {
                mailIds.TryAddValue(mail.Id);
            }
        }

        //private void AddNewMailIds(IEnumerable<TheMail> mails)
        //{
        //    foreach (var mail in mails)
        //    {
        //        TryAddMailId(mail.Id);
        //    }
        //}

        //private bool TryAddMailId(string mailId)
        //{
        //    var isAdded = false;
        //    if (!_allMailIds.Contains(mailId))
        //    {
        //        _allMailIds.Add(mailId);
        //        isAdded = true;
        //    }
        //    return isAdded;
        //}

        //private IEnumerable<Message> FetchAllMessages(DictionaryEmailServerParam serverParams, CachedEmailBox cachedEmailBox)
        //{
        //    using (var client = new Pop3Client())
        //    {
        //        // Connect to the server
        //        client.Connect(serverParams.Hostname, serverParams.Port, serverParams.UseSsl);
        //        // Authenticate ourselves towards the server
        //        client.Authenticate($"recent:{cachedEmailBox.Login}", cachedEmailBox.Password);
        //        // Get the number of messages in the inbox
        //        var messageCount = client.GetMessageCount();
        //        // We want to download all messages
        //        // Messages are numbered in the interval: [1, messageCount]
        //        // Ergo: message numbers are 1-based.
        //        // Most servers give the latest message the highest number
        //        for (int i = messageCount; i > 0; i--)
        //        {
        //            var message = client.GetMessage(i);
        //            yield return message;
        //        }
        //    }
        //}

        private Emails FetchNewEmails(DictionaryEmailServerParam serverParams, CachedEmailBox cachedEmailBox)
        {
            Emails newEmails = new Emails();
            using (var client = new ImapClient())
            {
                // For demo-purposes, accept all SSL certificates
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect(serverParams.Hostname, serverParams.Port, serverParams.UseSsl);
                client.Authenticate(cachedEmailBox.Login, cachedEmailBox.Password);

                //  Inbox emails
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                var newInboxMails = GetNewMails(inbox, EmailFolderType.Inbox, cachedEmailBox);
                newEmails.InboxEmails.AddRange(newInboxMails);

                //  Outbox emails
                var outboxFolder = client.GetFolder(SpecialFolder.Sent);
                outboxFolder.Open(FolderAccess.ReadOnly);
                var newOutboxMails = GetNewMails(outboxFolder, EmailFolderType.Outbox, cachedEmailBox);
                newEmails.OutboxEmails.AddRange(newOutboxMails);

                //  Spam emails
                var spamFolder = client.GetFolder(SpecialFolder.Junk);
                spamFolder.Open(FolderAccess.ReadOnly);
                var newSpamMails = GetNewMails(spamFolder, EmailFolderType.Spam, cachedEmailBox);
                newEmails.SpamEmails.AddRange(newSpamMails);

                //  Deleted emails
                var deletedFolder = client.GetFolder(SpecialFolder.Trash);
                deletedFolder.Open(FolderAccess.ReadOnly);
                var newDeletedMails = GetNewMails(deletedFolder, EmailFolderType.Deleted, cachedEmailBox);
                newEmails.DeletedEmails.AddRange(newDeletedMails);

                client.Disconnect(true);
            }
            return newEmails;
        }

        private IEnumerable<TheMail> GetNewMails(IMailFolder folder, EmailFolderType folderType, CachedEmailBox cachedEmailBox)
        {
            var mailIds = GetMailIds(folderType);
            for (int i = 0; i < folder.Count; i++)
            {
                var message = folder.GetMessage(i);
                if (mailIds.TryAddValue(message.MessageId))
                {
                    var mail = message.GetTheMail();
                    FillMailExtraFields(mail, folderType, cachedEmailBox);
                    yield return mail;
                }
            }
        }  

        private HashSet<string> GetMailIds(EmailFolderType folderType)
        {
            switch (folderType)
            {
                case EmailFolderType.Inbox:
                    return _inboxMailIds;
                case EmailFolderType.Outbox:
                    return _outboxMailIds;
                case EmailFolderType.Spam:
                    return _spamMailIds;
                case EmailFolderType.Deleted:
                    return _deletedMailIds;
                default:
                    return null;
            }
        }

        //private IEnumerable<TheMail> GetNewMails(IEnumerable<Message> messages, CachedEmailBox cachedEmailBox)
        //{
        //    foreach(var message in messages)
        //    {
        //        if(TryAddMailId(message.Headers.MessageId))
        //        {
        //            var mail = message.GetTheMail();
        //            FillMailExtraFields(mail, cachedEmailBox);
        //            yield return mail;
        //        }
        //    }
        //}

        private void FillMailExtraFields(TheMail mail, EmailFolderType folderType, CachedEmailBox cachedEmailBox)
        {
            mail.EmailFolderTypeId = (int)folderType;
            mail.ChachedEmailBoxId = cachedEmailBox.Id.Value;
        }

        private void InsertMails(IEnumerable<TheMail> mails)
        {
            foreach (var mail in mails)
            {
                _dbDataManager.InsertMail(mail);
            }
        }
        
        private class Emails
        {
            public List<TheMail> InboxEmails { get; } = new List<TheMail>();
            public List<TheMail> OutboxEmails { get; } = new List<TheMail>();
            public List<TheMail> SpamEmails { get; } = new List<TheMail>();
            public List<TheMail> DeletedEmails { get; } = new List<TheMail>();
        }

    }

}
