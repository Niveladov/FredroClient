using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.DAL.Attributes;

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
        [RelatedTable(typeof(DictionaryEmailServer))]
        [DisplayName("Почтовый сервер")]
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
        [DisplayName("Название хоста")]
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
        [DisplayName("Использовать Ssl")]
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
        [DisplayName("Номер порта")]
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
        [DisplayName("Для исходящих сообщений")]
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
        [DisplayName("Для входящих сообщений")]
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
