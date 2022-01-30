using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CustomExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int tipi için yazılan extension method çağrısı
            //int sayi = 0;
            //sayi.xyz();

            //Linq Extension Method çağrısı
            string[] kelimeler = { "klavye", "masa", "laptop", "monitor", "mouse" };

            var result = kelimeler.Sirala(p => p, false);
            //var result = kelimeler.Sirala(p => p.Length, false);

            foreach (var kelime in result)
            {
                Console.WriteLine(kelime);
            }

            Console.ReadKey();
        }
    }

    public static class LinqCustomExtension
    {
        //Int tipi için yazılan extension method kullanımı
        //public static void xyz(this int sayi)
        //{
        //}

        //Linq Extension method çağrısı
        public static IOrderedEnumerable<TSource> Sirala<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, bool isAsending)
        {
            if (isAsending)
                return source.OrderBy(keySelector);
            else
                return source.OrderByDescending(keySelector);
        }
    }
}
