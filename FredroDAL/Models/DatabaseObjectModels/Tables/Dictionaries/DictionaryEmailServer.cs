using System;
using System.Runtime.Serialization;

namespace FredroDAL.Models.DatabaseObjectModels.Tables.Dictionaries
{
    [DataContract]
    public sealed class DictionaryEmailServer : DbObjectBaseModel
    {
        //default properties
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public bool? IsDel { get; set; }
        [DataMember]
        public DateTime? CreationDate { get; set; }
        [DataMember]
        public int? CreatedBy { get; set; }

        //private fields
        private string _caption;
        private string _code;
        private string _originClientUrl;
        private string _popHostname;
        private bool _popUseSsl;
        private int _popPort;
        private string _imapHostname;
        private bool _imapUseSsl;
        private int _imapPort;
        private string _smtpHostname;
        private bool _smtpUseSsl;
        private int _smtpPort;

        //properties
        [DataMember]
        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                if (value != _caption)
                {
                    _caption = value;
                    NotifyPropertyChanged(nameof(Caption));
                }
            }
        }
        [DataMember]
        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                if (value != _code)
                {
                    _code = value;
                    NotifyPropertyChanged(nameof(Code));
                }
            }
        }
        [DataMember]
        public string OriginClientUrl
        {
            get
            {
                return _originClientUrl;
            }
            set
            {
                if (value != _originClientUrl)
                {
                    _originClientUrl = value;
                    NotifyPropertyChanged(nameof(OriginClientUrl));
                }
            }
        }
        [DataMember]
        public string PopHostname
        {
            get
            {
                return _popHostname;
            }
            set
            {
                if (value != _popHostname)
                {
                    _popHostname = value;
                    NotifyPropertyChanged(nameof(PopHostname));
                }
            }
        }
        [DataMember]
        public bool PopUseSsl
        {
            get
            {
                return _popUseSsl;
            }
            set
            {
                if (value != _popUseSsl)
                {
                    _popUseSsl = value;
                    NotifyPropertyChanged(nameof(PopUseSsl));
                }
            }
        }
        [DataMember]
        public int PopPort
        {
            get
            {
                return _popPort;
            }
            set
            {
                if (value != _popPort)
                {
                    _popPort = value;
                    NotifyPropertyChanged(nameof(PopPort));
                }
            }
        }
        [DataMember]
        public string ImapHostname
        {
            get
            {
                return _imapHostname;
            }
            set
            {
                if (value != _imapHostname)
                {
                    _imapHostname = value;
                    NotifyPropertyChanged(nameof(ImapHostname));
                }
            }
        }
        [DataMember]
        public bool ImapUseSsl
        {
            get
            {
                return _imapUseSsl;
            }
            set
            {
                if (value != _imapUseSsl)
                {
                    _imapUseSsl = value;
                    NotifyPropertyChanged(nameof(ImapUseSsl));
                }
            }
        }
        [DataMember]
        public int ImapPort
        {
            get
            {
                return _imapPort;
            }
            set
            {
                if (value != _imapPort)
                {
                    _imapPort = value;
                    NotifyPropertyChanged(nameof(ImapPort));
                }
            }
        }
        [DataMember]
        public string SmtpHostname
        {
            get
            {
                return _smtpHostname;
            }
            set
            {
                if (value != _smtpHostname)
                {
                    _smtpHostname = value;
                    NotifyPropertyChanged(nameof(SmtpHostname));
                }
            }
        }
        [DataMember]
        public bool SmtpUseSsl
        {
            get
            {
                return _smtpUseSsl;
            }
            set
            {
                if (value != _smtpUseSsl)
                {
                    _smtpUseSsl = value;
                    NotifyPropertyChanged(nameof(SmtpUseSsl));
                }
            }
        }
        [DataMember]
        public int SmtpPort
        {
            get
            {
                return _smtpPort;
            }
            set
            {
                if (value != _smtpPort)
                {
                    _smtpPort = value;
                    NotifyPropertyChanged(nameof(SmtpPort));
                }
            }
        }

    }
}
