using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis
{
    public class KrediKart : Odeme 
    {
        public Int64 KartNo { get; set; }
        public string KartTipi { get; set; }
        public string KartTarih { get; set; }
        public string KardCvv { get; set; }

        public KrediKart(Int64 KartNo, string KartTipi, string KartTarih, string KardCvv,int Miktar)
        {
            this.KartNo = KartNo;
            this.KartTipi = KartTipi;
            this.KartTarih = KartTarih;
            this.KardCvv = KardCvv;
            this.Miktar = Miktar;
        }
        
    }
}
