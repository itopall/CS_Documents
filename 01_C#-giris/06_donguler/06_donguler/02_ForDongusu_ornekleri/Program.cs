using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ForDongusu_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region örnek 1
            //1 ile 50 arasındaki çift sayıları yazdıran program
            //for (int i = 2; i <= 50; i += 2)
            //    Console.WriteLine(i);

            #endregion

            #region örnek 2
            //klavyeden girilen başlangıç ve bitiş sayıları arasındaki tek sayıların toplamını bulup ekrana yazdıran program
            //Console.Write("başlangıç değeri giriniz: ");
            //int bas = Convert.ToInt32(Console.ReadLine());
            //Console.Write("bitiş değeri giriniz: ");
            //int bit = Convert.ToInt32(Console.ReadLine());
            //int tt = 0;
            // yöntem 1

            //for (; bas <= bit; bas++)
            //{
            //    if (bas % 2 == 1)
            //    {
            //        Console.WriteLine(bas);
            //        tt += bas;
            //    }

            //}
            //Console.WriteLine(tt);
            // yöntem 2
            //for (int i = bas; i<= bit; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        //Console.WriteLine(i);
            //        tt += i;

            //    }
            //}
            //Console.WriteLine(tt);
            #endregion

            #region örnek 3
            // 1 - 100 arasındaki 5'e veya 7'ye tam bölünen sayıları ekrana yazdırma
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i%5 == 0 || i%7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region örnek 4
            // klavyeden giriline bir cümlenin her harfinin döngü ile alt alta ekrana yazdıran programı yazalım
            //Console.Write("cumle giriniz: ");
            //string cumle = Console.ReadLine();

            //for (int i = 0; i < cumle.Length; i++)
            //{
            //    Console.WriteLine(cumle[i]);
            //}

            #endregion

            #region örnek 5
            //1'den 25 e kadar olan sayıları birer birer yan yana ekrana yazdıran 5 in her katında alt satıra geçen program
            //for (int i = 1; i <= 25; i++)
            //{
            //    Console.Write(i);
            //    if (i%5 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            #endregion

            #region örnek 6
            // 1 den 10 kadar olan çarpım tablosunu sonuclarıyla beraber ekrana yazdıran programı yazalım
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {

            //        Console.WriteLine("{0} * {1} = {2}" ,i, j, i * j);

            //    }
            //}
            #endregion

            #region örnek 7
            //10 elamanlı bir int dizisi oluşturalım ve değerlerini rastgele atayalım.sonrasında 10 ten büyük olanları değerleri ekrana yazdıracağız.
            //int[] sayilar = {12, 45, 1, 36, 78, 65, 3, 4,69,5 };
            //for(int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > 10)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            #endregion

            #region örnek 8
            //klavyeden girilen 5 adet sayıyı bir diziye atarak küçükten büyüğe sıralayıp ekrana yazdırıp programı yazalım
            //int[] sayilar = new int[5];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.Write("sayı giriniz: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Array.Sort(sayilar);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            #endregion

            #region örnek 9
            //2x4 lük bir dizi oluşturup elemanları ekrana yazdıran program
            int[,] dizi =
            {
                {1,2,3,4 },
                {5,6,7,8 }
            };
            for(int i = 0; i < dizi.GetLength(0); i++)
            {
                for(int j = 0;j < dizi.GetLength(1); j++)
                    Console.Write(dizi[i, j] + " ");
                Console.WriteLine();
            }
            #endregion
            Console.ReadKey();
        }
    }
}
