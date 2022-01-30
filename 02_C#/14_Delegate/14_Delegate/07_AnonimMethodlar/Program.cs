using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_AnonimMethodlar
{
    delegate void IslemHandler();
    delegate double MatematikHandler(int sayi);
    class Program
    {
        static void Main(string[] args)
        {
            //Anonim methodlar, bir delege nesnenin oluşturulması sırasında, işaret edeceği methodun da aynı yerde tanımlanmasına imkan sağlar. Diğer bir değişle bir methodu başka bir methodun içinde tanımlayabiliriz


            IslemHandler handler = delegate 
            {
                Console.WriteLine("Anonim method örneği çalıştı");
            };
            handler += delegate
             {
                 Console.WriteLine("Anonim method örneği2 çalışltı");
             };
            handler();

            //Parametre alan anonim method örneği
            MatematikHandler handler2 = KareAl;//Normal kullanım

            handler2 += delegate (int a)//Anonim method kullanımı
            {
               return Math.Pow(a, 2);
            };

            Console.WriteLine(handler2(3));
            Console.ReadKey();
        }
        static double KareAl(int a)
        {
            return Math.Pow(a, 2);
        }
    }
}
