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
            var hostname = "pop.gmail.com";
            var port = 995;
            var useSsl = true;
            var username = "figamalum@gmail.com";
            var password = "ghekkafigamalum1994";
            var messages = EmailHelper.FetchAllMessages(hostname, port, useSsl, username, password);
            //EmailHelper.SendEmailAsync().GetAwaiter();
            Console.Read();
        }
    }
}
