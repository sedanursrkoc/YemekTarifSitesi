using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekTarifSitesi.Models
{
    public class Yemek
    {
        public int Id { get; set; }
        public string YemekAdi { get; set; }
        public string? Malzemeler { get; set; }
        public string Tarif { get; set; }
        public double? Puan { get; set; }
        public string Fotograf { get; set; }
        
    }
}
