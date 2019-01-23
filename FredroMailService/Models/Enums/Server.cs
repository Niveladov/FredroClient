using FredroMailService.ExtraClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroMailService.Models.Enums
{
    internal enum Server
    {
        [Description("Сервер входящей почты - pop.gmail.com")]
        [Pop(Hostname = "pop.gmail.com", Port = 995, UseSsl = true)]
        [Smtp(Hostname = "smtp.gmail.com", Port = 587, UseSsl = true)]//Port = 587, UseSsl = false
        [Imap(Hostname = "imap.gmail.com", Port = 993, UseSsl = true)]
        Gmail = 0,

        [Description("Сервер входящей почты - pop.mail.ru")]
        [Pop(Hostname = "pop.mail.ru", Port = 995, UseSsl = true)]
        [Smtp(Hostname = "smtp.mail.ru", Port = 465, UseSsl = true)]
        [Imap(Hostname = "imap.mail.ru", Port = 993, UseSsl = true)]
        Mail = 1,

        [Description("Сервер входящей почты - pop.yandex.ru")]
        [Pop(Hostname = "pop.yandex.ru", Port = 995, UseSsl = true)]
        [Smtp(Hostname = "smtp.yandex.ru", Port = 465, UseSsl = true)]
        [Imap(Hostname = "imap.yandex.ru", Port = 993, UseSsl = true)]
        Yandex = 2
    }
}
