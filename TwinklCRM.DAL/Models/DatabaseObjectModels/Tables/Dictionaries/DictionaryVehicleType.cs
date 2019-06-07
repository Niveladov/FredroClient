using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries
{
    [DataContract]
    public partial class DictionaryVehicleType : DbObjectBaseModel
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

        //properties
        [DataMember]
        [DisplayName("Название")]
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

    }
}
