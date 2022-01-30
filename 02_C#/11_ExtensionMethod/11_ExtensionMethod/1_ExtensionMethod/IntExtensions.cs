using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ExtensionMethod
{
    public static class IntExtensions
    {
        //this keyword'ü extensions methoda çevirmek için kullanılır.
        public static string KarakterTamamla(this int sayi, int karakterSayisi)
        {
            //sayi: 1000
            //karakterSayisi: 10
            //return: 0000001000
            string sonuc = sayi.ToString();
            int donusSayisi = karakterSayisi - sonuc.Length;
            for (int i = 0; i < donusSayisi; i++)
                sonuc = "0" + sonuc;

            return sonuc;
        }
    }
}
