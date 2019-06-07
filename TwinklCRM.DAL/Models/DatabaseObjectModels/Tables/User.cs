using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels.Tables
{
    [DataContract]
    public partial class User : DbObjectBaseModel
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
        private string _login;
        private string _passwordHash;
        private string _firstName;
        private string _lastName;
        private string _middleName;
        private bool _isAdmin;

        //properties
        [DataMember]
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                if (value != _login)
                {
                    _login = value;
                    NotifyPropertyChanged(nameof(Login));
                }
            }
        }
        [DataMember]
        public string PasswordHash
        {
            get
            {
                return _passwordHash;
            }
            set
            {
                if (value != _passwordHash)
                {
                    _passwordHash = value;
                    NotifyPropertyChanged(nameof(PasswordHash));
                }
            }
        }
        [DataMember]
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value != _firstName)
                {
                    _firstName = value;
                    NotifyPropertyChanged(nameof(FirstName));
                }
            }
        }
        [DataMember]
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value != _lastName)
                {
                    _lastName = value;
                    NotifyPropertyChanged(nameof(LastName));
                }
            }
        }
        [DataMember]
        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                if (value != _middleName)
                {
                    _middleName = value;
                    NotifyPropertyChanged(nameof(MiddleName));
                }
            }
        }
        [DataMember]
        public bool IsAdmin
        {
            get
            {
                return _isAdmin;
            }
            set
            {
                if (value != _isAdmin)
                {
                    _isAdmin = value;
                    NotifyPropertyChanged(nameof(IsAdmin));
                }
            }
        }

        //navigation properties
        [IgnoreDataMember]
        public ICollection<CachedEmailBox> ChachedEmailBoxes { get; set; } = new List<CachedEmailBox>();
    }
}