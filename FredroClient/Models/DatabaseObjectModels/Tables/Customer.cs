using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models.DatabaseObjectModels.Tables
{
    internal sealed class Customer
    {
        //shared properties
        public int? Id { get; set; }
        public bool? IsDel { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreatedBy { get; set; }
        //my properties
        public string SubjectName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Source { get; set; }
    }
}
