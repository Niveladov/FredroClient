using DevExpress.XtraEditors;
using FredroClient.Models;
using OpenPop.Mime;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

        public static ServerSettings GetServerSettings(this Enum enumValue)
        {
            ServerSettings serverSettings = new ServerSettings();
            MemberInfo[] memberInfo = enumValue.GetType().GetMember(enumValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] protocolAttrs = memberInfo[0].GetCustomAttributes(typeof(ProtocolAttribute), true);
                if (protocolAttrs != null && protocolAttrs.Length > 0)
                {
                    var popAttr = protocolAttrs.OfType<PopAttribute>().Single();
                    serverSettings.Pop.Hostname = popAttr.Hostname;
                    serverSettings.Pop.UseSsl = popAttr.UseSsl;
                    serverSettings.Pop.Port = popAttr.Port;

                    var smtpAttr = protocolAttrs.OfType<SmtpAttribute>().Single();
                    serverSettings.Smtp.Hostname = smtpAttr.Hostname;
                    serverSettings.Smtp.UseSsl = smtpAttr.UseSsl;
                    serverSettings.Smtp.Port = smtpAttr.Port;

                    var imapAttr = protocolAttrs.OfType<ImapAttribute>().Single();
                    serverSettings.Imap.Hostname = imapAttr.Hostname;
                    serverSettings.Imap.UseSsl = imapAttr.UseSsl;
                    serverSettings.Imap.Port = imapAttr.Port;
                }
            }
            return serverSettings;
        }

        //public static int GetPort<T>(this T enumerationValue) where T : struct
        //{
        //    Type type = enumerationValue.GetType();
        //    if (!type.IsEnum)
        //    {
        //        throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
        //    }

        //    MemberInfo[] memberInfo = type.GetMember(enumerationValue.ToString());
        //    if (memberInfo != null && memberInfo.Length > 0)
        //    {
        //        object[] attrs = memberInfo[0].GetCustomAttributes(typeof(PortAttribute), false);

        //        if (attrs != null && attrs.Length > 0)
        //        {
        //            return ((PortAttribute)attrs[0]).Port;
        //        }
        //    }
        //    return -1;
        //}

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
                XtraMessageBox.Show(ex.Message, "Ошибка",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        public static async Task SendEmailAsync(TheMessage message, Credentials creds, SmtpProtocol smtp)
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

                SmtpClient smtpClient = new SmtpClient(smtp.Hostname, smtp.Port);
                smtpClient.Credentials = new NetworkCredential(creds.Username, creds.Password);
                smtpClient.EnableSsl = smtp.UseSsl;
                await smtpClient.SendMailAsync(m);
                XtraMessageBox.Show("Письмо отправлено!", "Успешно",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Ошибка",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        internal static TheMessage GetTheMessage(this Message message)
        {
            var attachmentParts = message.FindAllAttachments();
            var plainTextParts = message.FindAllMessagePartsWithMediaType(PLAIN_TEXT);
            var htmlTextParts = message.FindAllMessagePartsWithMediaType(HTML_TEXT);
            var theMessage = new TheMessage();
            theMessage.Id = message.Headers.MessageId;
            theMessage.FromFullRaw = message.Headers.From.Raw;
            theMessage.FromAddress = message.Headers.From.Address;
            theMessage.FromDisplayName = message.Headers.From.DisplayName;
            theMessage.ToFullRaw = message.Headers.To.FirstOrDefault()?.Raw;
            theMessage.ToAddress = message.Headers.To.FirstOrDefault()?.Address;
            theMessage.ToDisplayName = message.Headers.To.FirstOrDefault()?.DisplayName;
            theMessage.Date = message.Headers.DateSent;
            theMessage.Subject = message.Headers.Subject;
            theMessage.Body = plainTextParts.FirstOrDefault()?.GetBodyAsText() ??
                                htmlTextParts.FirstOrDefault()?.GetBodyAsText();
            //---↓↓↓---костыль---↓↓↓---
            if (theMessage.FromDisplayName.Contains("??") || theMessage.Subject.Contains("??"))
            {
                var messageBytes = message.RawMessage;
                var messageString = Encoding.UTF8.GetString(messageBytes);
                if (theMessage.FromDisplayName.Contains("??"))
                {
                    var regexFrom = new Regex("From:\\s(.*)\r\n");
                    var matchFrom = regexFrom.Match(messageString);
                    var fullFromString = matchFrom.Value.Trim().Substring(6).Replace("\"", ""); //6 = "From: ".length
                    theMessage.FromFullRaw = fullFromString;
                    theMessage.FromDisplayName = fullFromString.Substring(0, fullFromString.IndexOf('<') - 1);
                }
                if (theMessage.Subject.Contains("??"))
                {
                    var regexSubj = new Regex("Subject:\\s(.*)\r\n");
                    var matchSubj = regexSubj.Match(messageString);
                    var fullSubjString = matchSubj.Value.Trim().Substring(9); // = "Subject: ".length
                    theMessage.Subject = fullSubjString;
                }
            }
            //---↑↑↑---костыль---↑↑↑---
            return theMessage;
        }


    }
}
