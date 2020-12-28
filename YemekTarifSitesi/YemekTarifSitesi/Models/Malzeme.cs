using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekTarifSitesi.Models
{
    public class Malzeme
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Miktar { get; set; }
        public string MiktarTur { get; set; }

    }
}
