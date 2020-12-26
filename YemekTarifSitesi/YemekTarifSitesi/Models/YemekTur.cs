using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekTarifSitesi.Models
{
    public class YemekTur
    {
        public int Id { get; set; }

        public int YemekId { get; set; }

        public int TurId { get; set; }

        public Yemek Yemek { get; set; }

        public Tur Tur { get; set; }
    }
}
