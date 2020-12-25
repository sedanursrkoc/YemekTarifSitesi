using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekTarifSitesi.Models
{
    public class Yorumlar
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
    }
}
