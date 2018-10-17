using OpenPop.Mime;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = FetchAllMessages("pop.gmail.com", 995, true, "figamalum@gmail.com", "ghekkafigamalum1994");
            //SendEmailAsync().GetAwaiter();
            Console.Read();
        }

        public static List<Message> FetchAllMessages(string hostname, int port, bool useSsl, string username, string password)
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

        private static async Task SendEmailAsync()
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("ghekka@mail.ru", "Eugeen");
            // кому отправляем
            MailAddress to = new MailAddress("figamalum@gmail.com");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            //вложения
            m.Attachments.Add(new Attachment("E://colors.txt"));
            // тема письма
            m.Subject = "Второй";
            // текст письма
            m.Body = "<h2>Второе письмо-тест работы smtp-клиента</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("ghekka@mail.ru", "24021974ghekka");
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(m);
            Console.WriteLine("Письмо отправлено");
        }

    }
}
