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
        private HashSet<string> _allMailIds;
        
        public EmailDeliveryManager(IDbDataManager dbDataManager)
        {
            try
            {
                _allMailIds = new HashSet<string>();
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
                var allMails = _dbDataManager.GetUserMails();
                if (allMails.Count > 0)
                {
                    OperationContext.Current.GetCallbackChannel<IMailboxCallback>().SendNewMails(allMails);
                    AddNewMailIds(allMails);
                }
                while (true)
                {
                    var allNewMails = new List<TheMail>();
                    foreach (var cachedEmailBox in SessionContext.Instance.CurrentUser.ChachedEmailBoxes)
                    {
                        var serverParams = cachedEmailBox.IncomingEmailServerParam;
                        var newMessages = FetchNewMails(serverParams, cachedEmailBox);
                        var newMails = GetNewMails(newMessages, cachedEmailBox).ToList();
                        if (newMails.Count > 0)
                        {
                            allNewMails.AddRange(newMails);
                            Task.Run(() => InsertMails(newMails)); //think about it
                        }
                    }
                    if (allNewMails.Count > 0)
                    {
                        OperationContext.Current.GetCallbackChannel<IMailboxCallback>().SendNewMails(allNewMails);
                    }
                    Thread.Sleep(MAIL_SERVER_ACCESS_PERIOD);
                }
            }
            catch
            {
                throw;
            }
        }

        private void AddNewMailIds(IEnumerable<TheMail> mails)
        {
            foreach (var mail in mails)
            {
                TryAddMailId(mail.Id);
            }
        }

        private bool TryAddMailId(string mailId)
        {
            var isAdded = false;
            if (!_allMailIds.Contains(mailId))
            {
                _allMailIds.Add(mailId);
                isAdded = true;
            }
            return isAdded;
        }

        private IEnumerable<Message> FetchNewMails(DictionaryEmailServerParam serverParams, CachedEmailBox cachedEmailBox)
        {
            using (var client = new Pop3Client())
            {
                // Connect to the server
                client.Connect(serverParams.Hostname, serverParams.Port, serverParams.UseSsl);
                // Authenticate ourselves towards the server
                client.Authenticate($"recent:{cachedEmailBox.Login}", cachedEmailBox.Password);
                // Get the number of messages in the inbox
                var messageCount = client.GetMessageCount();
                // We want to download all messages
                // Messages are numbered in the interval: [1, messageCount]
                // Ergo: message numbers are 1-based.
                // Most servers give the latest message the highest number
                for (int i = messageCount; i > 0; i--)
                {
                    var message = client.GetMessage(i);
                    yield return message;
                }
            }
        }

        private IEnumerable<TheMail> GetNewMails(IEnumerable<Message> messages, CachedEmailBox cachedEmailBox)
        {
            foreach(var message in messages)
            {
                if(TryAddMailId(message.Headers.MessageId))
                {
                    var mail = message.GetTheMail();
                    FillMailExtraFields(mail, cachedEmailBox);
                    yield return mail;
                }
            }
        }

        private void FillMailExtraFields(TheMail mail, CachedEmailBox cachedEmailBox)
        {
            mail.IsOutcoming = (cachedEmailBox.Login == mail.FromAddress);
            mail.IsIncoming = (cachedEmailBox.Login == mail.ToAddress);
            mail.ChachedEmailBoxId = cachedEmailBox.Id.Value;
        }

        private void InsertMails(IEnumerable<TheMail> mails)
        {
            foreach (var mail in mails)
            {
                _dbDataManager.InsertMail(mail);
            }
        }

    }

}
