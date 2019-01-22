using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace FredroDAL.Models.DatabaseObjectModels.Tables
{
    [DataContract]
    public sealed class TheMessage
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string FromFullRaw { get; set; }
        [DataMember]
        public string FromAddress { get; set; }
        [DataMember]
        public string FromDisplayName { get; set; }
        [DataMember]
        public string ToFullRaw { get; set; }
        [DataMember]
        public string ToAddress { get; set; }
        [DataMember]
        public string ToDisplayName { get; set; }
        [DataMember]
        public DateTime? Date { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string MailedBy { get; set; } //отправлено через
        [DataMember]
        public string SignedBy { get; set; } //подписано
        [DataMember]
        public string Body { get; set; }
        [DataMember]
        public bool IsOutcoming { get; set; }
        [DataMember]
        public bool IsIncoming { get; set; }
        [DataMember]
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
