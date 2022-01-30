using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GenericExtensionMethod
{
    public static class GenericExtensions
    {
        //Sadece int değişkenlerde çıkkacak bir method
        public static int Kareal(this int sayi)
        {
            return sayi * sayi;
        }

        //Tüm .Net nesnelerinde çıkacak bir method
        public static void HerYerdeCikacakMethod(this object sayi)
        {

        }

        //Sadece struct nesnelerde çıkacak bir method
        public static void SadeceStruct<T>(this T obj) where T : struct
        {

        }

        //Sadece Urun neslerinde çıkacak bir method
        public static void SadeceUrun<T>(this T obj) where T : Urun
        {

        }
    }
}
