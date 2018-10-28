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

        public static HostParameters GetHostParameters(this Enum enumValue)
        {
            HostParameters hostParams = new HostParameters();
            MemberInfo[] memberInfo = enumValue.GetType().GetMember(enumValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] hostAttrs = memberInfo[0].GetCustomAttributes(typeof(HostAttribute), false);
                if (hostAttrs != null && hostAttrs.Length > 0)
                {
                    hostParams.Hostname = ((HostAttribute)hostAttrs[0]).Host;
                }
                object[] useSslAttrs = memberInfo[0].GetCustomAttributes(typeof(UseSslAttribute), false);
                if (useSslAttrs != null && useSslAttrs.Length > 0)
                {
                    hostParams.UseSsl = ((UseSslAttribute)useSslAttrs[0]).UseSsl;
                }
                object[] portAttrs = memberInfo[0].GetCustomAttributes(typeof(PortAttribute), false);
                if (portAttrs != null && portAttrs.Length > 0)
                {
                    hostParams.Port = ((PortAttribute)portAttrs[0]).Port;
                }
            }
            return hostParams;
        }

        public static int GetPort<T>(this T enumerationValue) where T : struct
        {
            Type type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
            }

            MemberInfo[] memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(PortAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((PortAttribute)attrs[0]).Port;
                }
            }
            return -1;
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
                XtraMessageBox.Show(ex.Message, "Ошибка",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        public static async Task SendEmailAsync(TheMessage message, string login, string password)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress(message.FromAddress, message.FromDisplayName);
            // кому отправляем
            MailAddress to = new MailAddress(message.ToAddress);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            //вложения
            //m.Attachments.Add(new Attachment("E://colors.txt"));
            // тема письма
            m.Subject = message.Subject;
            // текст письма
            m.Body = message.Body;
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential(login, password);
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(m);
            XtraMessageBox.Show("Письмо отправлено!", "Успешно", 
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

            // отправитель - устанавливаем адрес и отображаемое в письме имя
            //MailAddress from = new MailAddress("ghekka@mail.ru", "Eugeen");
            // кому отправляем
            //MailAddress to = new MailAddress("figamalum@gmail.com");
            // создаем объект сообщения
            //MailMessage m = new MailMessage(from, to);
            //вложения
            //m.Attachments.Add(new Attachment("E://colors.txt"));
            // тема письма
            //m.Subject = "Второй";
            // текст письма
            //m.Body = "<h2>Второе письмо-тест работы smtp-клиента</h2>";
            // письмо представляет код html
            //m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            //SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            // логин и пароль
            //smtp.Credentials = new NetworkCredential("ghekka@mail.ru", "24021974ghekka");
            //smtp.EnableSsl = true;
            //await smtp.SendMailAsync(m);
            //Console.WriteLine("Письмо отправлено");
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
            theMessage.ToFullRaw = message.Headers.To.First().Raw;
            theMessage.ToAddress = message.Headers.To.First().Address;
            theMessage.ToDisplayName = message.Headers.To.First().DisplayName;
            theMessage.Date = message.Headers.DateSent;
            theMessage.Subject = message.Headers.Subject;
            theMessage.Body = plainTextParts.FirstOrDefault()?.GetBodyAsText() ??
                                htmlTextParts.FirstOrDefault()?.GetBodyAsText();
            return theMessage;
        }


    }
}
