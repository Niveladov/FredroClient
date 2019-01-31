using FredroDAL.Models.Contexts;
using FredroDAL.Models.DatabaseObjectModels.Tables;
using FredroDAL.Models.DatabaseObjectModels.Tables.Dictionaries;
using FredroDAL.Models.DatabaseObjectModels.Views;
using OpenPop.Mime;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FredroClient.ExtraClasses
{
    internal static class FredroHelper
    {
        const string PLAIN_TEXT = "text/plain";
        const string HTML_TEXT = "text/html";

        public static string GetDescription(this Enum enumerationValue)
        {
            //Tries to find a DescriptionAttribute for a potential friendly name
            //for the enum
            MemberInfo[] memberInfo = enumerationValue.GetType().GetMember(enumerationValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            //If we have no description attribute, just return the ToString of the enum
            return enumerationValue.ToString();
        }

        internal static List<Message> FetchAllMessages(string hostname, int port, bool useSsl, string username, string password)
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
                    var allMessages = new List<Message>(messageCount);
                    // Messages are numbered in the interval: [1, messageCount]
                    // Ergo: message numbers are 1-based.
                    // Most servers give the latest message the highest number
                    for (int i = messageCount; i > 0; i--)
                    {
                        allMessages.Add(client.GetMessage(i));
                    }
                    // Now return the fetched messages
                    return allMessages;
                }
            }
            catch(Exception ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                return null;
            }
        }

        internal static TheMail GetTheMail(this Message message)
        {
            var attachmentParts = message.FindAllAttachments();
            var plainTextParts = message.FindAllMessagePartsWithMediaType(PLAIN_TEXT);
            var htmlTextParts = message.FindAllMessagePartsWithMediaType(HTML_TEXT);
            var theMail = new TheMail();
            theMail.Id = message.Headers.MessageId;
            theMail.FromFullRaw = message.Headers.From.Raw;
            theMail.FromAddress = message.Headers.From.Address;
            theMail.FromDisplayName = message.Headers.From.DisplayName;
            theMail.ToFullRaw = message.Headers.To.FirstOrDefault()?.Raw;
            theMail.ToAddress = message.Headers.To.FirstOrDefault()?.Address;
            theMail.ToDisplayName = message.Headers.To.FirstOrDefault()?.DisplayName;
            theMail.Date = message.Headers.DateSent;
            theMail.Subject = message.Headers.Subject;
            theMail.Body = plainTextParts.FirstOrDefault()?.GetBodyAsText() ??
                                htmlTextParts.FirstOrDefault()?.GetBodyAsText();
            //---↓↓↓---костыль---↓↓↓---
            if (theMail.FromDisplayName.Contains("??") || theMail.Subject.Contains("??"))
            {
                var messageBytes = message.RawMessage;
                var messageString = Encoding.UTF8.GetString(messageBytes);
                if (theMail.FromDisplayName.Contains("??"))
                {
                    var regexFrom = new Regex("From:\\s(.*)\r\n");
                    var matchFrom = regexFrom.Match(messageString);
                    var fullFromString = matchFrom.Value.Trim().Substring(6).Replace("\"", ""); //6 = "From: ".length
                    theMail.FromFullRaw = fullFromString;
                    theMail.FromDisplayName = fullFromString.Substring(0, fullFromString.IndexOf('<') - 1);
                }
                if (theMail.Subject.Contains("??"))
                {
                    var regexSubj = new Regex("Subject:\\s(.*)\r\n");
                    var matchSubj = regexSubj.Match(messageString);
                    var fullSubjString = matchSubj.Value.Trim().Substring(9); // = "Subject: ".length
                    theMail.Subject = fullSubjString;
                }
            }
            //---↑↑↑---костыль---↑↑↑---
            return theMail;
        }

        internal static async void SaveNewMessages(List<TheMail> allMails)
        {
            using (var db = new FredroDbContext())
            {
                foreach (var message in allMails)
                {
                    db.Mails.AddIfNotExists(message);
                }
                await db.SaveChangesAsync();
            }
        }

        internal static void TruncateMails()
        {
            using (var db = new FredroDbContext())
            {
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE TheMails");
            }
        }

        internal static BindingList<ViewVehicle> GetAllViewVehicles()
        {
            try
            {
                BindingList<ViewVehicle> viewVehicles = null;
                using (var db = new FredroDbContext())
                {
                    db.ViewVehicles.Load();
                    viewVehicles = db.ViewVehicles.Local.ToBindingList();
                }
                return viewVehicles;
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                return null;
                throw ex;
            }
        }

        internal static BindingList<Vehicle> GetAllVehicles()
        {
            try
            {
                BindingList<Vehicle> vehicles = null;
                using (var db = new FredroDbContext())
                {
                    db.Vehicles.Load();
                    vehicles = db.Vehicles.Local.ToBindingList();
                }
                return vehicles;
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                return null;
                throw ex;
            }
        }
        
        internal static BindingList<Deal> GetAllDeals()
        {
            try
            {
                BindingList<Deal> deals = null;
                using (var db = new FredroDbContext())
                {
                    db.Deals.Load();
                    deals = db.Deals.Local.ToBindingList();
                }
                return deals;
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                return null;
                throw ex;
            }
        }

        internal static BindingList<ViewAssignedDeal> GetAllViewAssignedDeals()
        {
            try
            {
                BindingList<ViewAssignedDeal> viewVehicles = null;
                using (var db = new FredroDbContext())
                {
                    db.ViewAssignedDeals.Load();
                    viewVehicles = db.ViewAssignedDeals.Local.ToBindingList();
                }
                return viewVehicles;
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                return null;
                throw ex;
            }
        }

        internal static Deal GetDeal(int dealId)
        {
            try
            {
                Deal deal = null;
                using (var db = new FredroDbContext())
                {
                    deal = db.Deals.Find(dealId);
                }
                return deal;
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                return null;
                throw ex;
            }
        }

        internal static ViewAssignedDeal GetViewAssignedDeal(int dealId)
        {
            try
            {
                ViewAssignedDeal deal = null;
                using (var db = new FredroDbContext())
                {
                    deal = db.ViewAssignedDeals.Find(dealId);
                }
                return deal;
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                return null;
                throw ex;
            }
        }

        internal static List<Deal> GetAssignedDeals()
        {
            try
            {
                List<Deal> deals = null;
                using (var db = new FredroDbContext())
                {
                    db.Deals.Load();
                    deals = db.Deals.Where(x => x.VehicleId != null).ToList();
                }
                return deals;
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                return null;
                throw ex;
            }
        }

        internal static List<Deal> GetNotAssignedDeals()
        {
            try
            {
                List<Deal> deals = null;
                using (var db = new FredroDbContext())
                {
                    db.Deals.Load();
                    deals = db.Deals.Where(x => x.VehicleId == null).ToList();
                }
                return deals;
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                return null;
                throw ex;
            }
        }

        internal static BindingList<Customer> GetAllCustomers()
        {
            try
            {
                BindingList<Customer> deals = null;
                using (var db = new FredroDbContext())
                {
                    db.Customers.Load();
                    deals = db.Customers.Local.ToBindingList();
                }
                return deals;
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                return null;
                throw ex;
            }
        }

        internal static BindingList<Performer> GetAllPerformes()
        {
            try
            {
                BindingList<Performer> deals = null;
                using (var db = new FredroDbContext())
                {
                    db.Performers.Load();
                    deals = db.Performers.Local.ToBindingList();
                }
                return deals;
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                return null;
                throw ex;
            }
        }

        internal static BindingList<DictionaryTripType> GetAllTripTypes()
        {
            try
            {
                BindingList<DictionaryTripType> deals = null;
                using (var db = new FredroDbContext())
                {
                    db.TripTypes.Load();
                    deals = db.TripTypes.Local.ToBindingList();
                }
                return deals;
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError(ex.Message);
                return null;
                throw ex;
            }
        }
    }

    public static class DbSetExtensions
    {
        public static T AddIfNotExists<T>(this DbSet<T> dbSet, T entity, Expression<Func<T, bool>> predicate = null) where T : class, new()
        {
            var exists = predicate != null ? dbSet.Any(predicate) : dbSet.Any();
            return !exists ? dbSet.Add(entity) : null;
        }
    }

}
