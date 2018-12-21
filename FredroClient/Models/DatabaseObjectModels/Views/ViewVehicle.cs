using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models.DatabaseObjectModels.Views
{
    internal sealed class ViewVehicle
    {
        public int? Id { get; set; }
        public string Name { get; set; } //марка, модель
        public string RegistrationNumber { get; set; } //номер
        public short? PassengersCount { get; set; } //кол-во пассажиров
        public int? ParentId { get; set; } 
    }
}
