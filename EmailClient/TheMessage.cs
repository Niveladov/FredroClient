using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailClient
{
    internal sealed class TheMessage
    {
        public string Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Date { get; set; }
        public string Subject { get; set; }
        public string MailedBy { get; set; } //отправлено через
        public string SignedBy { get; set; } //подписано
        public string Body { get; set; }
    }
}
