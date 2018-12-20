using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models.DatabaseObjectModels.Tables.Dictionaries
{
    internal sealed class DictionaryVehicleType
    {
        //shared properties
        public int? Id { get; set; }
        public bool? IsDel { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreatedBy { get; set; }
        //my properties
        public string Name { get; set; }
    }
}
