using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0, sayi2 = 10;
            #region If kullanımı
            if (sayi1 > sayi2)
            {
                Console.WriteLine("sayi1 büyüktür sayi2'den");
            };
            if (sayi1 < sayi2)
            {
                Console.WriteLine("sayi1 küçüktür sayi2'den");
            }
            if (sayi1 == sayi2)
            {
                Console.WriteLine("iki sayı eşitti");
            }
            #endregion

            #region If-Else
            if (sayi1 > sayi2)
            {
                Console.WriteLine("sayi1 büyüktür sayi2'den");
            }
            else
            {
                Console.WriteLine("sayi1 büyük değildir sayi2'den");
            }
            #endregion

            #region If - Else If kullanımı
            if (sayi1 > sayi2)
            {
                Console.WriteLine("sayi1 büyüktür sayi2'den");
            }
            else if (sayi1 < sayi2)
            {
                Console.WriteLine("sayi1 küçüktür sayi2'den");
            }
            else if (sayi1 == sayi2)
            {
                Console.WriteLine("sayi1 eşittir sayi2'ye");
            }
            #endregion

            #region Scope'suz kullanım
            if (sayi1 > sayi2)
                Console.WriteLine("sayi1 büyüktür sayi2'den");
            else if (sayi1 < sayi2)
                Console.WriteLine("sayi1 küçüktür sayi2'den");
            else if (sayi1 == sayi2)
                Console.WriteLine("sayi1 eşittir sayi2'ye");
            #endregion

            #region iç içe if kullanımı
            if (sayi1 > 0)
            {
                if(sayi1 < 100)
                {
                    Console.WriteLine("sayi1 sıfırdan büyük 100'den küçüktür");
                }
                else
                {
                    Console.WriteLine("sayi1 100den büyüktür");
                }
            }
            else
            {
                Console.WriteLine("sayi1 küçüktür 0'dan.");
            }
            #endregion

            #region Birden fazla koşulu aynı anda uygulama
            if (sayi1 > 0 && sayi1 < 100)
                Console.WriteLine("sayi1 0 ile 100 arasındadır");
            else
                Console.WriteLine("sayi1 0 ile 100 arasında değildir.");
            //veya operatörü "||" koşullarından birinin sağlanmasını gerekitir.
            if (sayi1 == 10 || sayi1 == 20)
                Console.WriteLine("sayi1 10 yada 20 dir");
            else
                Console.WriteLine("sayi1 10 ya da 20 değildir.");
            // büyük ya da eşit kullanımı
            if (sayi1 >= 0)
                Console.WriteLine("sayi1 0'a eşit yada büyüktür.");
            // küçük yada eşit kullanımı
            if (sayi1 <= 0)
                Console.WriteLine("sayi1 0'a eşit yada küçüküt.");
            // eşit değil kullanımı
            if (sayi1 != 100)
                Console.WriteLine("sayi1 100'e eşit değildir.");


            #endregion

            #region üçlü kullanım(ternary)
            // üçlü kullanım If-Else
            string sonuc = sayi1 > sayi2 ? "sayi1 büyüktür sayi2'den" : "sayi1 büyük değildir sayi2'den";

            //iç içe üçlü kullanım
            string sonuc2 = sayi1 > sayi2 ? "sayi1 büyüktür sayi2'den" :
                            sayi1 < sayi2 ? "sayi1 küçüktür sayi2'den" : "sayi1 eşittir sayi2'ye";
            #endregion

            




            Console.ReadKey();
        }
    }
}
