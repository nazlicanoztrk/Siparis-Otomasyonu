using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis
{
    public class Musteri
    {
        public int musterino { get; set; }
        public string kullaniciAdi { get; set; }
        public string parola { get; set; }
        public string isim { get; set; }
        public string yetkili { get; set; }
        public string surName { get; set; }
        public string Adres { get; set; }
        public Musteri()
        {

        }

        public Musteri(int musterino ,string kullaniciAdi, string parola, string isim, string surName, string Adres, string yetkili)
        {
            this.kullaniciAdi = kullaniciAdi;
            this.musterino = musterino;
            this.yetkili   = yetkili;
            this.parola = parola;
            this.isim = isim;
            this.surName = surName;
            this.Adres = Adres;
        }
        public Siparis siparis { get; set; }
        public Musteri(Siparis s)
        {
            this.siparis = s;
        }
    }

}
