using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region artarak dönen for döngüsü
            //for(int i=0; i < 10;i++)
            //{
            //    //Console.WriteLine("merhaba");
            //    Console.WriteLine(i);
            //}
            #endregion

            #region azalarak dönen for döngüsü
            //for(int i=10;i>0;i--)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region karakterler arasında dönen for döngüsü
            //for(char karakter = 'a'; karakter <= 'z'; karakter++)
            //{
            //    Console.Write(karakter + " ");
            //}
            #endregion

            #region döngü içerisinde continue kullanımı
            //continue anahtar sözcüğü döngü içerisinde o anki satırı atlatıp bir sonraki adıma geçmek için kullanılır.
            //for(int i=0;i<=10;i++)
            //{
            //    if (i == 5)
            //        continue;
            //    Console.WriteLine(i);
            //}
            #endregion

            #region döngü içerisinde break kullanımı
            // break anahtar sözcüğü döngüden çıkma işlemini gerçekleştirir.
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //        break;
            //    Console.WriteLine(i);

            //}
            #endregion

            #region 5 er 5 er arttırma
            //for(int i=0;i<=100;i+=5)//i=i+5 olur
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region scopesiz kullanım
            //for (int i = 0; 1 <= 10; i++)
            //    Console.WriteLine(i);
            #endregion

            #region sonsuz döngü ve if koşulu ile durduruluna kadar dönen for döngüsü
            //sonsuz döngü
            //for (; ; )
            //    Console.Write("merhaba");
            //int i = 0;
            //for(; ; )
            //{
            //    if (i <= 10)
            //    {
            //        Console.WriteLine(i + " ");
            //        i++;
            //    }
            //    else
            //        break;
            //}
            //Console.WriteLine("döngüden çıkıldı");
            #endregion

            #region iç içe for döngüsü kullanımı
            //for(int i = 0; i <= 10; i++)
            //{
            //    for(int j = 0; j <= 10; j++)
            //    {
            //        Console.WriteLine("i: {0} * j:{1} = {2}", i, j, i * j);
            //    }
            //}
            #endregion

            #region 
            #endregion
            Console.ReadKey();
        }
    }
}
