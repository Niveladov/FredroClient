﻿using System;
using System.Runtime.Serialization;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries
{
    [DataContract]
    public sealed class DictionaryTripType : DbObjectBaseModel
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
        private string _name;
        private string _code;

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

    }
}
