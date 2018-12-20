﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.Models.DatabaseObjectModels.Tables
{
    internal sealed class Deal
    {
        //shared properties
        public int? Id { get; set; }
        public bool? IsDel { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreatedBy { get; set; }
        //my properties
        public DateTime? DateStart { get; set; } //начало
        public DateTime? DateEnd { get; set; } //окончание
        public string Route { get; set; } //маршрут
        public int? CustomerId { get; set; } //заказчик
        public int? PerformerId { get; set; } //исполнитель
        public int? VehicleId { get; set; } //автобус
        public int? TripTypeId { get; set; } //тип поезки
        public int? DealStatusId { get; set; } //статус сделки
        public string Description { get; set; } //описание
    }
}
