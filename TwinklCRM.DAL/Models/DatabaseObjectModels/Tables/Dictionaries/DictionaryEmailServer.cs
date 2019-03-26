using System;
using System.Runtime.Serialization;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries
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

    }
}
