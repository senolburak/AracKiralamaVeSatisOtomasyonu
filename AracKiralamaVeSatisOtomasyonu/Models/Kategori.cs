using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaVeSatisOtomasyonu.Models
{
    public class Kategori
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public List<Arac> Araclar { get; set; }

        public override string ToString()
        {
            return KategoriAdi;
        }
    }
}
