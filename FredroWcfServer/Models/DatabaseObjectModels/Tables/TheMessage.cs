using System;

namespace FredroWcfServer.Models.DatabaseObjectModels.Tables
{
    public sealed class TheMessage
    {
        public string Id { get; set; }
        public string FromFullRaw { get; set; }
        public string FromAddress { get; set; }
        public string FromDisplayName { get; set; }
        public string ToFullRaw { get; set; }
        public string ToAddress { get; set; }
        public string ToDisplayName { get; set; }
        public DateTime? Date { get; set; }
        public string Subject { get; set; }
        public string MailedBy { get; set; } //отправлено через
        public string SignedBy { get; set; } //подписано
        public string Body { get; set; }
        public bool IsOutcoming { get; set; }
        public bool IsIncoming { get; set; }
        public bool IsRead { get; set; }

        //private bool _isRead;
        //public bool IsRead
        //{
        //    get { return _isRead; }
        //    set
        //    {
        //        if (_isRead != value)
        //        {
        //            _isRead = value;
        //            if (_isRead)
        //            {
        //                PictureMail = Resources.read_32x38;
        //            }
        //        }
        //    }
        //}

        //[NotMapped]
        //public Bitmap PictureMail { get; private set; } = Resources.unread_32x32;
    }
}
