using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LambdaSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 5, 15, 8, 45 };
            string[] kelimeler = { "Bahadır", "Ömer", "İlker", "Halil İbrahim", "Utku", "Berat", "Rümeysa" };

            #region Örnek 1
            //Eski Yöntem
            List<int> ciftSayilar = new List<int>();
            foreach (var s in sayilar)
            {
                if (s % 2 == 0)
                {
                    ciftSayilar.Add(s);
                }
            }

            //Çift sayılar sorgulamasını query operatörleri aracılığıyla yapıyoruz.
            var sorgu = from s in sayilar
                        where s % 2 == 0
                        select s;

            //Aynı sorguyu query operatörlerini kullanmadan lambda ile yapalım.
            var sorgu2 = sayilar.Where(p => p % 2 == 0);

            //sorgu1'de query operatörüyle yazdığımız kodlar, proje compile edildiğinde sorgu2'deki Method çağrısına dönüşür.
            #endregion

            #region Örnek 2
            var sorgu3 = from s in sayilar
                         select s * 2;

            var sorgu4 = sayilar.Select<int, int>(x => x * 2);
            var sorgu5 = sayilar.Select(x => x * 2); //Generic parametreler tiplerini otomatik alabilirler.
            #endregion

            #region Örnek 3
            var sorgu6 = from k in kelimeler
                         select k.Length; //int'leri select ettik.

            var sorgu7 = kelimeler.Select(p=> p.Length);

            foreach (var k in sorgu7)
                Console.WriteLine(k);
            #endregion

            Console.ReadKey();
        }
    }
}
