using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries
{
    [DataContract]
    public class DictionaryEmailServerParam : DbObjectBaseModel
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
        private int? _emailServerId;
        private string _hostname;
        private bool _useSsl;
        private int _port;
        private bool? _isOutgoing;
        private bool? _isIncoming;

        //properties
        [DataMember]
        public int? EmailServerId
        {
            get
            {
                return _emailServerId;
            }
            set
            {
                if (value != _emailServerId)
                {
                    _emailServerId = value;
                    NotifyPropertyChanged(nameof(EmailServerId));
                }
            }
        }
        [DataMember]
        public string Hostname
        {
            get
            {
                return _hostname;
            }
            set
            {
                if (value != _hostname)
                {
                    _hostname = value;
                    NotifyPropertyChanged(nameof(Hostname));
                }
            }
        }
        [DataMember]
        public bool UseSsl
        {
            get
            {
                return _useSsl;
            }
            set
            {
                if (value != _useSsl)
                {
                    _useSsl = value;
                    NotifyPropertyChanged(nameof(UseSsl));
                }
            }
        }
        [DataMember]
        public int Port
        {
            get
            {
                return _port;
            }
            set
            {
                if (value != _port)
                {
                    _port = value;
                    NotifyPropertyChanged(nameof(Port));
                }
            }
        }
        [DataMember]
        public bool? IsOutgoing
        {
            get
            {
                return _isOutgoing;
            }
            set
            {
                if (value != _isOutgoing)
                {
                    _isOutgoing = value;
                    NotifyPropertyChanged(nameof(IsOutgoing));
                }
            }
        }
        [DataMember]
        public bool? IsIncoming
        {
            get
            {
                return _isIncoming;
            }
            set
            {
                if (value != _isIncoming)
                {
                    _isIncoming = value;
                    NotifyPropertyChanged(nameof(IsIncoming));
                }
            }
        }

    }
}
