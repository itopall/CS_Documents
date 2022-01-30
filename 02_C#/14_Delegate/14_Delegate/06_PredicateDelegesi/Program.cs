using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PredicateDelegesi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Int Orneği
            List<int> sayilar = new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);
            sayilar.Add(25);

            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi % 2 == 0 ? "Çifttir" : "Tektir");
            //}
            var ciftler = sayilar.FindAll(CiftMi);
            foreach (var cift in ciftler)
            {
                Console.WriteLine(cift);
            }
            #endregion

            #region String Örneği
            List<string> kelimeler = new List<string>();
            kelimeler.Add("Rüştü");
            kelimeler.Add("Berat");
            kelimeler.Add("Sefa");
            kelimeler.Add("Rümeysa");
            kelimeler.Add("test");

            var buyukHarfler = kelimeler.FindAll(BasHarfBuyukMu);
            foreach (var bh in buyukHarfler)
                Console.WriteLine(bh);
            //Uzun isim olanları ayıklayan methodu yazalım( 5 harften büyük olanlar uzun sayılsın)
            
            foreach (var bh in kelimeler.FindAll(BesHarftenBuyukmu))
                Console.WriteLine(bh);
            #endregion
            
            Console.ReadKey();
        }
        static bool CiftMi(int a)
        {
            return a % 2 == 0;
        }

        static bool BasHarfBuyukMu(string s)
        {
            return Char.IsUpper(s[0]); 
        }

        static bool BesHarftenBuyukmu(string s)
        {
            return s.Length > 5;
        }
    }
}
