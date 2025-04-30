using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaVeSatisOtomasyonu.Models
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public List<Kiralama> Kiralamalar { get; set; }
        public List<Satis> Satislar { get; set; }
    }
}
