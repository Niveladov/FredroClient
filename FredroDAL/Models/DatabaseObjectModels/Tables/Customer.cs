using System;
using System.Runtime.Serialization;

namespace FredroDAL.Models.DatabaseObjectModels.Tables
{
    [DataContract]
    public sealed class Customer : DbObjectBaseModel
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
        private string _subjectName;
        private string _phoneNumber;
        private string _emailAddress;
        private string _source;

        //properties
        [DataMember]
        public string SubjectName
        {
            get
            {
                return _subjectName;
            }
            set
            {
                if (value != _subjectName)
                {
                    _subjectName = value;
                    NotifyPropertyChanged(nameof(SubjectName));
                }
            }
        }
        [DataMember]
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value != _phoneNumber)
                {
                    _phoneNumber = value;
                    NotifyPropertyChanged(nameof(PhoneNumber));
                }
            }
        }
        [DataMember]
        public string EmailAddress
        {
            get
            {
                return _emailAddress;
            }
            set
            {
                if (value != _emailAddress)
                {
                    _emailAddress = value;
                    NotifyPropertyChanged(nameof(EmailAddress));
                }
            }
        }
        [DataMember]
        public string Source
        {
            get
            {
                return _source;
            }
            set
            {
                if (value != _source)
                {
                    _source = value;
                    NotifyPropertyChanged(nameof(Source));
                }
            }
        }

    }
}
