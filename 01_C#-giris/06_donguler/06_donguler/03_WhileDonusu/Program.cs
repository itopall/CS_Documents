using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WhileDonusu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region sayi 10 olana kadar dönen while dongusu
            //int sayi = 1;
            //while(sayi <= 10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            #endregion

            #region Değer True old. sürece dönen döngü
            //bool durum = true;
            //while (durum == true)
            //{
            //    Console.WriteLine(durum);

            //    Console.Write("devam etmek istiyor musunuz? (E/H): ");
            //    string cevap = Console.ReadLine();
            //    if (cevap == "H")
            //        durum = false;
            //}
            //Console.WriteLine("Döngüden çıkıldı..");
            #endregion

            #region Değer E old. sürece dönen döngü
            //string devamEtsinMi = "E";
            //while(devamEtsinMi == "E")
            //{
            //    Console.WriteLine(devamEtsinMi);
            //    Console.Write("Devam etmek istiyor musun? E/H: ");
            //    devamEtsinMi = Console.ReadLine();

            //}
            //Console.WriteLine("döngüden çıkıldı..");
            #endregion

            #region continue ve break kullanımı
            //int counter = 0;
            //while(counter <= 10)
            //{
            //    counter++;
            //    if (counter == 5 || counter == 6)
            //        continue;
            //    if (counter == 8)
            //        break;
            //    Console.WriteLine(counter);

            //}
            #endregion

            #region sonsuz döngü
            //while (true)
            //{
            //    Console.Write(1);
            //}
            //while (1 == 1)
            //{
            //    Console.Write("devam etmek istiyor musunuz? (E/H): ");
            //    string devam = Console.ReadLine();
            //    if (devam != "E")
            //        break;
            //}
            #endregion
            Console.ReadKey();
        }
    }
}
