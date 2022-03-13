using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst.Entity
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }

        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public string UrunKategori { get; set; }
        public int UrunStok { get; set; } 
        public string Acıklama { get; set; }

        //1 ürünün 1 kategorisi var demek
        public Kategori kategori { get; set; }
    }
}
