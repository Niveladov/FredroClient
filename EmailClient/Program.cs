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
            //"recent:" before username show messages 
            //that were recieved during last 30 days messages
            var username = "recent:figamalum@gmail.com"; 
            var password = "ghekkafigamalum1994";
            var messages = EmailHelper.FetchAllMessages(hostname, port, useSsl, username, password);
            var theMessages = new List<TheMessage>();
            foreach (var message in messages)
            {
                theMessages.Add(EmailHelper.ParseMessage(message));
            }
            var mCount = messages.Count;
            var tCount = theMessages.Count;
            //EmailHelper.SendEmailAsync().GetAwaiter();
            Console.Read();
        }


        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);

        //    DevExpress.Skins.SkinManager.EnableFormSkins();
        //    DevExpress.UserSkins.BonusSkins.Register();
        //    UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

        //    Application.Run(new Form1());
        //}

    }
}
