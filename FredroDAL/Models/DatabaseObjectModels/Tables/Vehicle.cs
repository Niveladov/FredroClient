using System;
using System.Runtime.Serialization;

namespace TwinkleDAL.Models.DatabaseObjectModels.Tables
{
    [DataContract]
    public sealed class Vehicle : DbObjectBaseModel
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
        private string _name; //марка, модель
        private string _registrationNumber; //номер
        private short? _passengersCount; //кол-во пассажиров   
        private int? _typeId; //тип ТС        

        //properties
        [DataMember]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged(nameof(Name));
                }
            }
        }
        [DataMember]
        public string RegistrationNumber
        {
            get
            {
                return _registrationNumber;
            }
            set
            {
                if (value != _registrationNumber)
                {
                    _registrationNumber = value;
                    NotifyPropertyChanged(nameof(RegistrationNumber));
                }
            }
        }
        [DataMember]
        public short? PassengersCount     
        {
            get
            {
                return _passengersCount;
            }
            set
            {
                if (value != _passengersCount)
                {
                    _passengersCount = value;
                    NotifyPropertyChanged(nameof(PassengersCount));
                }
            }
        }
        [DataMember]
        public int? TypeId
        {
            get
            {
                return _typeId;
            }
            set
            {
                if (value != _typeId)
                {
                    _typeId = value;
                    NotifyPropertyChanged(nameof(TypeId));
                }
            }
        }

    }
}
