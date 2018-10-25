using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.ExtraClasses
{
    public enum Hostname
    {
        [Description("Сервер входящей почты - pop.gmail.com")]
        [Host("pop.gmail.com")]
        [UseSsl(true)]
        [Port(995)]
        gmail = 0,

        [Description("Сервер входящей почты - pop.mail.ru")]
        [Host("pop.gmail.com")]
        [UseSsl(true)]
        [Port(995)]
        mail = 1,

        [Description("Сервер входящей почты - pop.yandex.ru")]
        [Host("pop.gmail.com")]
        [UseSsl(true)]
        [Port(995)]
        yandex = 2
    }

}
