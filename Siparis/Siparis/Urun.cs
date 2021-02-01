using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis
{
    public class Urun
    {
        public string KargoAgirlik { get; set; }
        public string Aciklama { get; set; }
        public decimal FiyatAl()
        {
            return Convert.ToDecimal(KargoAgirlik) * 0.02m;
        }
        public double AgirlikAl()
        {
            return Convert.ToDouble( KargoAgirlik);
        }
    }
}
