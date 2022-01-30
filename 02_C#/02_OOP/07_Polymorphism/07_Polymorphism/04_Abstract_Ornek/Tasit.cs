using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstract_Ornek
{
    //abstract class oluşturalım
    abstract class Tasit
    {
        //nonabstract property oluşturduk
        public string Marka { get; set; }
        public string Model { get; set; }
        public double TabanFiyati { get; set; }

        //abstract property olarak oluşturduk
        public abstract double Fiyat { get; }

        public Tasit(string marka, string model, double tabanFiyatı)
        {
            Marka = marka;
            Model = model;
            TabanFiyati = tabanFiyatı;
        }
    }
}
