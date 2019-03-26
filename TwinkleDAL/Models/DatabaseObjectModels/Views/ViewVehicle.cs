using System;
using System.Runtime.Serialization;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels.Views
{
    [DataContract]
    public sealed class ViewVehicle : DbObjectBaseModel
    {
        //default properties
        [DataMember]
        public int? Id { get; set; }

        //private fields
        private string _name; //марка, модель
        private string _registrationNumber; //номер
        private short? _passengersCount; //кол-во пассажиров   
        private int? _parentId; //тип ТС        

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
        public int? ParentId
        {
            get
            {
                return _parentId;
            }
            set
            {
                if (value != _parentId)
                {
                    _parentId = value;
                    NotifyPropertyChanged(nameof(ParentId));
                }
            }
        }

    }
}
