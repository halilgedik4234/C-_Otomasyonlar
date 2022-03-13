using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst.Entity
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string KategoriDetay { get; set; }

        //1 e çok ilişki bir ürünnün 1 kategorisi olur fakat 1 kategoride birden fazla ürün yer alır
        public ICollection<Urunler> Urunlers { get; set; }
    }
}
