using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstract_Ornek
{
    class Araba : Tasit
    {
        public string yakitTuru { get; set; }
        public string vitesTuru { get; set; }

        public Araba(string marka,string model,double tabanFiyat,string yakitTuru,string vitesTuru) : base(marka, model, tabanFiyat)
        {
            this.yakitTuru = yakitTuru;
            this.vitesTuru = vitesTuru;
        }
        //tasit classı içerisindeki abstract property'nin get methodu her bir devired class(Araba) içerisinde implemente etmemiz gerekiyor
        public override double Fiyat
        {
            get
            {
                //Yakıt türü dizel olan arabalar için taban fiyatı 5000 arttırdık
                if (yakitTuru == "Dizel")
                    TabanFiyati += 5000;
                if (vitesTuru == "Otomatik")
                    TabanFiyati += 10000;

                return TabanFiyati;
            }
        }
    }
}
