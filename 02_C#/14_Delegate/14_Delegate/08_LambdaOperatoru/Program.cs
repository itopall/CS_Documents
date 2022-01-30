using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LambdaOperatoru
{
    delegate void Temsilci();
    delegate void Temsilci2(int a, int b);
    delegate int temsilci3(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            //lambda, anonim methodları daha kolay bir şekilde yazmamızı sağlayan operatördür

            #region Örnek 1
            Temsilci t = delegate
            {
                Console.WriteLine("Anonim method...");
            };
            t += () =>
            {
                Console.WriteLine("Lambda syntax'ı..");
            };



            t();
            #endregion

            #region Örnek 2
            Temsilci2 t2 = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };

            //Lambda yazımında parametrelerin tiplerinin söylenmesine gerek yoktur istenirse söylenebilir.
            //t2 += (int p1, int p2) =>
            t2 += (p1,p2) =>
            {
                Console.WriteLine(p1 - p2);
            };

            t2(20, 10);
            #endregion

            #region Örnek 3 
            temsilci3 t3 = delegate (int a, int b)
            {
               return a + b;
            };

            //Lambda operatörünün kolaylık sağladığı nokta; geriye sadece değer dönen başka bir kod satırına sahip olmayan methodların kolaylıkla yazılmasıdır.
            t3 += (x, y) => x - y;
            t3 += (x, y) => x + y;
            t3 += (x, y) => x * y;
            t3 += (x, y) => x / y;

            int sonuc = t3.Invoke(100, 50);
            Console.WriteLine(sonuc);
            #endregion

            #region Örnek 4
            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Anonim method olmasaydı.
            //foreach (var s in sayilar.FindAll(CiftMi))
            //    Console.WriteLine(s);


            //Anonim method kullanımı
            foreach (var s in sayilar.FindAll(delegate (int a) { return a % 2 == 0; }))
                Console.WriteLine(s);
            Console.WriteLine("----------------------");

            //Anonim methodda lambda kullanımı
            foreach (var s in sayilar.FindAll(p => p % 2 == 0))
                Console.WriteLine(s);
            #endregion

            Console.ReadKey();
        }
        static bool CiftMi(int a)
        {
            return a % 2 == 0;
        }
    }
}
