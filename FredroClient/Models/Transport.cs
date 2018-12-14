using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models
{
    internal sealed class Vehicle
    {
        public int? Id { get; set; }
        public string Name { get; set; } //марка, модель
        public string RegistrationNumber { get; set; } //номер
        public short PassengersNumber { get; set; } //кол-во пассажиров
    }
}
