using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis
{
    public class SiparisDetay
    {
        public int Miktar { get; set; }
        public string VergiDurumu { get; set; }
        public SiparisDetay()
        {

        }
        public SiparisDetay(int miktar, string vergidurumu)
        {
            this.Miktar = miktar;
            this.VergiDurumu = vergidurumu;

        }

        public decimal AraToplamHesapla(decimal fiyat)
        {
            return fiyat;
        }
        public double AgirlikHesapla(double agirlik, int miktar)
        {
            this.Miktar = miktar;
            return agirlik * miktar;
        }
    }
}
