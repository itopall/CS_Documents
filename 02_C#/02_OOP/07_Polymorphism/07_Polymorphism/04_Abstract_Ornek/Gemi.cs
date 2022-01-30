using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstract_Ornek
{
    class Gemi : Tasit
    {
        public int KamaraSayisi { get; set; }
        public override double Fiyat
        {
            get
            {
                double sonuc = TabanFiyati * (KamaraSayisi * 50000);
                return sonuc;
            }
        }
        public Gemi(string marka, string model, double tabanFiyati, int kamaraSayisi):base(marka,model,tabanFiyati)
        {
            KamaraSayisi = kamaraSayisi; 
        }
    }
}
