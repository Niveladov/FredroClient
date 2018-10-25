using FredroClient.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class TheMessage
    {
        public string Id { get; set; }
        public string FromFullRaw { get; set; }
        public string FromAddress { get; set; }
        public string FromDisplayName { get; set; }
        public string To { get; set; }
        public string Date { get; set; }
        public string Subject { get; set; }
        public string MailedBy { get; set; } //отправлено через
        public string SignedBy { get; set; } //подписано
        public string Body { get; set; }

        private bool _isRead;
        public bool IsRead
        {
            get { return _isRead; }
            set
            {
                if (_isRead != value)
                {
                    _isRead = value;
                    if (_isRead)
                    {
                        PictureMail = Resources.read_32x38;
                    }
                }
            }
        }

        public Bitmap  PictureMail { get; private set; } = Resources.unread_32x32;


    }
}
