using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FredroDAL.Models.DatabaseObjectModels.Tables
{
    [DataContract]
    public sealed class CachedEmail : DbObjectBaseModel
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
        private int? _userId;
        private int? _emalServiceHostId;
        private string _login;
        //ToDo: to change field type to byte[] and to apply encryption
        private string _password;

        //properties
        [DataMember]
        public int? UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                if (value != _userId)
                {
                    _userId = value;
                    NotifyPropertyChanged(nameof(UserId));
                }
            }
        }
        [DataMember]
        public int? EmalServiceHostId
        {
            get
            {
                return _emalServiceHostId;
            }
            set
            {
                if (value != _emalServiceHostId)
                {
                    _emalServiceHostId = value;
                    NotifyPropertyChanged(nameof(EmalServiceHostId));
                }
            }
        }
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
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value != _password)
                {
                    _password = value;
                    NotifyPropertyChanged(nameof(Password));
                }
            }
        }
    }
}
