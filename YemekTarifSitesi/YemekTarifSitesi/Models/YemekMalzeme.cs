using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekTarifSitesi.Models
{
    public class YemekMalzeme
    {
        public int Id { get; set; }

        public int YemekId { get; set; }

        public int MalzemeId { get; set; }

        public Yemek Yemek { get; set; }

        public Malzeme Malzeme { get; set; }
    }
}
