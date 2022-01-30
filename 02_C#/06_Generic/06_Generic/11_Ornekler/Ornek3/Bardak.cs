using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Ornekler.Ornek3
{
    class Bardak
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        public string Doldur<T>(T icecekTipi) where T : Icecek
        {
            //return typeof(T).Name + " dolduruldu.";
            return icecekTipi.GetType().Name + " dolduruldu.";
        }
    }
}
