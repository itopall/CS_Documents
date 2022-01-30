using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstract_Ornek
{
    class Ucak : Tasit
    {
        public int kapasite { get; set; }

        public Ucak(string marka, string model, int tabanFiyati, int _kapasite):base(marka,model,tabanFiyati)
        {
            kapasite = _kapasite;
        }
        public override double Fiyat
        {
            get
            {
                double sonuc = TabanFiyati + (kapasite * 100);
                return sonuc;

            }
        }
    }
}
