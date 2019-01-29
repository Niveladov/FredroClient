using System;
using System.Runtime.Serialization;

namespace FredroDAL.Models.DatabaseObjectModels.Tables.Dictionaries
{
    [DataContract]
    public class DictionaryEmailServer : DbObjectBaseModel
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
        private int? _activeOutgoingEmailServerParamId;
        private int? _activeIncomingEmailServerParamId;

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
        public int? ActiveOutgoingEmailServerParamId
        {
            get
            {
                return _activeOutgoingEmailServerParamId;
            }
            set
            {
                if (value != _activeOutgoingEmailServerParamId)
                {
                    _activeOutgoingEmailServerParamId = value;
                    NotifyPropertyChanged(nameof(ActiveOutgoingEmailServerParamId));
                }
            }
        }
        [DataMember]
        public int? ActiveIncomingEmailServerParamId
        {
            get
            {
                return _activeIncomingEmailServerParamId;
            }
            set
            {
                if (value != _activeIncomingEmailServerParamId)
                {
                    _activeIncomingEmailServerParamId = value;
                    NotifyPropertyChanged(nameof(ActiveIncomingEmailServerParamId));
                }
            }
        }

        //navigation properties
        [DataMember]
        public virtual DictionaryEmailServerParam ActiveOutgoingEmailServerParam { get; set; }
        [DataMember]
        public virtual DictionaryEmailServerParam ActiveIncomingEmailServerParam { get; set; }

    }
}
