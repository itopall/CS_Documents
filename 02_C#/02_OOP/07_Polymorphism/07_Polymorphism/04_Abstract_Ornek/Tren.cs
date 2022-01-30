using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstract_Ornek
{
    class Tren : Tasit
    {
        public int vagonSayisi { get; set; }
        public string sinif { get; set; }

        public Tren(string marka, string model,double tabanFiyati,int _vagonSayisi,string _sinif):base(marka,model, tabanFiyati)
        {
            vagonSayisi = _vagonSayisi;
            sinif = _sinif;
        }
        public override double Fiyat
        {
            get
            {
                if (sinif == "A")
                    TabanFiyati += 15000;
                if (sinif == "B")
                    TabanFiyati += 10000;
                if (sinif == "C")
                    TabanFiyati += 5000;
                if (vagonSayisi > 5)
                    TabanFiyati += 10000;
                return TabanFiyati ;
            }
        }
    }
}
