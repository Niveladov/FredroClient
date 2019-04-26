using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries
{
    [DataContract]
    public sealed class DictionaryHierarchy : DbObjectBaseModel
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
        private string _caption;
        private int? _parentId;
        private bool _isCategory;

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
        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                if (value != _caption)
                {
                    _caption = value;
                    NotifyPropertyChanged(nameof(Caption));
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
        [DataMember]
        public bool IsCategory
        {
            get
            {
                return _isCategory;
            }
            set
            {
                if (value != _isCategory)
                {
                    _isCategory = value;
                    NotifyPropertyChanged(nameof(IsCategory));
                }
            }
        }
    }
}
