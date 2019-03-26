using System;
using System.Runtime.Serialization;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels.Views
{
    [DataContract]
    public sealed class ViewAssignedDeal : DbObjectBaseModel
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
        private DateTime? _dateStart; //начало
        private DateTime? _dateEnd; //окончание
        private string _route; //маршрут
        private int? _customerId; //заказчик
        private int? _performerId; //исполнитель
        private int? _vehicleId; //автобус
        private int? _tripTypeId; //тип поезки
        private int? _dealStatusId; //статус сделки
        private string _description; //описание
        private short? _passengersCount;
        private string _tripTypeName;

        //properties
        [DataMember]
        public DateTime? DateStart
        {
            get
            {
                return _dateStart;
            }
            set
            {
                if (value != _dateStart)
                {
                    _dateStart = value;
                    NotifyPropertyChanged(nameof(DateStart));
                }
            }
        }
        [DataMember]
        public DateTime? DateEnd
        {
            get
            {
                return _dateEnd;
            }
            set
            {
                if (value != _dateEnd)
                {
                    _dateEnd = value;
                    NotifyPropertyChanged(nameof(DateEnd));
                }
            }
        }
        [DataMember]
        public string Route
        {
            get
            {
                return _route;
            }
            set
            {
                if (value != _route)
                {
                    _route = value;
                    NotifyPropertyChanged(nameof(Route));
                }
            }
        }
        [DataMember]
        public int? CustomerId
        {
            get
            {
                return _customerId;
            }
            set
            {
                if (value != _customerId)
                {
                    _customerId = value;
                    NotifyPropertyChanged(nameof(CustomerId));
                }
            }
        }
        [DataMember]
        public int? PerformerId
        {
            get
            {
                return _performerId;
            }
            set
            {
                if (value != _performerId)
                {
                    _performerId = value;
                    NotifyPropertyChanged(nameof(PerformerId));
                }
            }
        }
        [DataMember]
        public int? VehicleId
        {
            get
            {
                return _vehicleId;
            }
            set
            {
                if (value != _vehicleId)
                {
                    _vehicleId = value;
                    NotifyPropertyChanged(nameof(VehicleId));
                }
            }
        }
        [DataMember]
        public int? TripTypeId
        {
            get
            {
                return _tripTypeId;
            }
            set
            {
                if (value != _tripTypeId)
                {
                    _tripTypeId = value;
                    NotifyPropertyChanged(nameof(TripTypeId));
                }
            }
        }
        [DataMember]
        public int? DealStatusId
        {
            get
            {
                return _dealStatusId;
            }
            set
            {
                if (value != _dealStatusId)
                {
                    _dealStatusId = value;
                    NotifyPropertyChanged(nameof(DealStatusId));
                }
            }
        }
        [DataMember]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value != _description)
                {
                    _description = value;
                    NotifyPropertyChanged(nameof(Description));
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
        public string TripTypeName
        {
            get
            {
                return _tripTypeName;
            }
            set
            {
                if (value != _tripTypeName)
                {
                    _tripTypeName = value;
                    NotifyPropertyChanged(nameof(TripTypeName));
                }
            }
        }

    }
}
