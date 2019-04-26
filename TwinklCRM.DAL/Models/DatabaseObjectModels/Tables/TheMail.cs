using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Runtime.Serialization;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels.Tables
{
    [DataContract]
    public sealed class TheMail : DbObjectBaseModel
    {
        //default properties
        [DataMember]
        public string Id { get; set; }
        
        //private fields
        private string _fromFullRaw;
        private string _fromAddress;
        private string _fromDisplayName;
        private string _toFullRaw;
        private string _toAddress;
        private string _toDisplayName;
        private DateTime? _date;
        private string _subject;
        private string _mailedBy; //отправлено через
        private string _signedBy; //подписано
        private string _body;
        private bool _isOutcoming;
        private bool _isIncoming;
        private bool _isRead;
        private int? _chachedEmailBoxId;
        private int? _emailFolderTypeId;

        //properties
        [DataMember]
        public string FromFullRaw
        {
            get
            {
                return _fromFullRaw;
            }
            set
            {
                if (value != _fromFullRaw)
                {
                    _fromFullRaw = value;
                    NotifyPropertyChanged(nameof(FromFullRaw));
                }
            }
        }
        [DataMember]
        public string FromAddress
        {
            get
            {
                return _fromAddress;
            }
            set
            {
                if (value != _fromAddress)
                {
                    _fromAddress = value;
                    NotifyPropertyChanged(nameof(FromAddress));
                }
            }
        }
        [DataMember]
        public string FromDisplayName
        {
            get
            {
                return _fromDisplayName;
            }
            set
            {
                if (value != _fromDisplayName)
                {
                    _fromDisplayName = value;
                    NotifyPropertyChanged(nameof(FromDisplayName));
                }
            }
        }
        [DataMember]
        public string ToFullRaw
        {
            get
            {
                return _toFullRaw;
            }
            set
            {
                if (value != _toFullRaw)
                {
                    _toFullRaw = value;
                    NotifyPropertyChanged(nameof(ToFullRaw));
                }
            }
        }
        [DataMember]
        public string ToAddress
        {
            get
            {
                return _toAddress;
            }
            set
            {
                if (value != _toAddress)
                {
                    _toAddress = value;
                    NotifyPropertyChanged(nameof(ToAddress));
                }
            }
        }
        [DataMember]
        public string ToDisplayName
        {
            get
            {
                return _toDisplayName;
            }
            set
            {
                if (value != _toDisplayName)
                {
                    _toDisplayName = value;
                    NotifyPropertyChanged(nameof(ToDisplayName));
                }
            }
        }
        [DataMember]
        public DateTime? Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (value != _date)
                {
                    _date = value;
                    NotifyPropertyChanged(nameof(Date));
                }
            }
        }
        [DataMember]
        public string Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                if (value != _subject)
                {
                    _subject = value;
                    NotifyPropertyChanged(nameof(Subject));
                }
            }
        }
        [DataMember]
        public string MailedBy
        {
            get
            {
                return _mailedBy;
            }
            set
            {
                if (value != _mailedBy)
                {
                    _mailedBy = value;
                    NotifyPropertyChanged(nameof(MailedBy));
                }
            }
        }
        [DataMember]
        public string SignedBy
        {
            get
            {
                return _signedBy;
            }
            set
            {
                if (value != _signedBy)
                {
                    _signedBy = value;
                    NotifyPropertyChanged(nameof(SignedBy));
                }
            }
        }
        [DataMember]
        public string Body
        {
            get
            {
                return _body;
            }
            set
            {
                if (value != _body)
                {
                    _body = value;
                    NotifyPropertyChanged(nameof(Body));
                }
            }
        }
        [DataMember]
        public bool IsRead
        {
            get
            {
                return _isRead;
            }
            set
            {
                if (value != _isRead)
                {
                    _isRead = value;
                    //if (_isRead) PictureMail = Resources.read_32x38;
                    NotifyPropertyChanged(nameof(IsRead));
                }
            }
        }
        [DataMember]
        public int? ChachedEmailBoxId
        {
            get
            {
                return _chachedEmailBoxId;
            }
            set
            {
                if (value != _chachedEmailBoxId)
                {
                    _chachedEmailBoxId = value;
                    NotifyPropertyChanged(nameof(ChachedEmailBoxId));
                }
            }
        }
        [DataMember]
        public int? EmailFolderTypeId
        {
            get
            {
                return _emailFolderTypeId;
            }
            set
            {
                if (value != _emailFolderTypeId)
                {
                    _emailFolderTypeId = value;
                    NotifyPropertyChanged(nameof(EmailFolderTypeId));
                }
            }
        }

        [NotMapped]
        public Bitmap PictureMail
        {
            get
            {
               return this.IsRead ? Properties.Resources.read_mail_32x38 : Properties.Resources.unread_mail_blue_32x32;
            }
        } 
    }
}
