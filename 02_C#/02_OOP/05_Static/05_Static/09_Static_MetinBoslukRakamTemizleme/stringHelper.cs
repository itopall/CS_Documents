using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Static_MetinBoslukRakamTemizleme
{
    static class stringHelper
    {
        public static string BoslukVeRakamTemizle(string metin)
        {
            //ilk olarak metinden boşlukları temizleyelim.
            metin = metin.Replace(" ", "");//Replace() metodu, ilk parametreyi(boşluk " ") ikinciyi parametreyle(empty "") değiştirirç

            //ikinci olarak rakamları temizleyelim.
            string[] rakamlar = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            foreach(var item in rakamlar)
            {
                metin = metin.Replace(item, "");//0 la empty olark değiştir.
            }
            return metin;
        }
    }
}
