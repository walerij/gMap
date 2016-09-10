using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValeraMaps.Models
{
    public class People
    {
        public string id { get; set; }
        public string name { get; set; } //имя формулиста
        public string numform { get; set; } //номер формулиста
        public double GeoLong { get; set; } // долгота - для карт google
        public double GeoLat { get; set; } // широта - для карт google
        public string info { get; set; } //информация
        public string photolink { get; set; } //ссылка на фото

    }
}