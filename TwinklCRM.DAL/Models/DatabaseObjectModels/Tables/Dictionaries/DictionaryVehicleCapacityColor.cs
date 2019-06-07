using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries
{
    [DataContract]
    public sealed class DictionaryVehicleCapacityColor : DbObjectBaseModel
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

        private short _minCapacity;
        private short _maxCapacity;
        private string _color;

        [DataMember]
        [DisplayName("Вместимость от")]
        public short MinCapacity
        {
            get
            {
                return _minCapacity;
            }
            set
            {
                if (value != _minCapacity)
                {
                    _minCapacity = value;
                    NotifyPropertyChanged(nameof(MinCapacity));
                }
            }
        }
        [DataMember]
        [DisplayName("Вместимость до")]
        public short MaxCapacity
        {
            get
            {
                return _maxCapacity;
            }
            set
            {
                if (value != _maxCapacity)
                {
                    _maxCapacity = value;
                    NotifyPropertyChanged(nameof(MaxCapacity));
                }
            }
        }
        [DataMember]
        [DisplayName("Цвет диапазона")]
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (value != _color)
                {
                    _color = value;
                    NotifyPropertyChanged(nameof(Color));
                }
            }
        }

    }
}
