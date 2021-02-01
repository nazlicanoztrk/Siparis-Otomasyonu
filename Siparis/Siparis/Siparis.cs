using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis
{
    public class Siparis
    {
        public string Tarih  { get; set; }
        public string Durum { get; set; }
        public SiparisDetay Detay { get; set; }
        public Siparis()
        {

        }
        public decimal VergiHesapla()
        {
            return 0.08m;
        }
        public decimal ToplamHesapla(decimal fiyat, decimal vergi, int adet)
        {
            return ((fiyat * vergi) + fiyat) * adet;
        }
        public double ToplamAgirlikHesapla(double agirlik)
        {
            return agirlik;
        }

    }
}
