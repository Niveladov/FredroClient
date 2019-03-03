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
using FredroDAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace FredroMailService.Models
{
    internal interface IMailDeliveryManager
    {
        void Join();
    }

    internal class EmailDeliveryManager : IMailDeliveryManager
    {
        private const int MAIL_SERVER_ACCESS_PERIOD = 5000;
        private IDbDataManager _dbDataManager;

        public HashSet<string> AllMailIds { get; private set; }
        
        public EmailDeliveryManager(IDbDataManager dbDataManager)
        {
            try
            {
                AllMailIds = new HashSet<string>();
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
                if (allMails.Count > 0) OperationContext.Current.GetCallbackChannel<IMailCallback>().SendNewMails(allMails);
                while (true)
                {
                    var allNewMails = new List<TheMail>();
                    foreach (var cachedEmailBox in SessionContext.Instance.CurrentUser.ChachedEmailBoxes)
                    {
                        var serverParams = cachedEmailBox.IncomingEmailServerParam;
                        var newMails = FetchNewMails(serverParams, cachedEmailBox);
                        allNewMails.AddRange(newMails);
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

        private List<TheMail> FetchNewMails(DictionaryEmailServerParam serverParams, CachedEmailBox cachedEmailBox)
        {
            try
            {
                // The client disconnects from the server when being disposed
                using (var client = new Pop3Client())
                {
                    // Connect to the server
                    client.Connect(serverParams.Hostname, serverParams.Port, serverParams.UseSsl);
                    // Authenticate ourselves towards the server
                    client.Authenticate(cachedEmailBox.Login, cachedEmailBox.Password);
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
                            mail.IsOutcoming = (cachedEmailBox.Login == mail.FromAddress);
                            mail.IsIncoming = (cachedEmailBox.Login == mail.ToAddress);
                            mail.ChachedEmailBoxId = cachedEmailBox.Id.Value;
                            AllMailIds.Add(mail.Id);
                            allMails.Add(mail);
                            _dbDataManager.InsertMail(mail);
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

}
