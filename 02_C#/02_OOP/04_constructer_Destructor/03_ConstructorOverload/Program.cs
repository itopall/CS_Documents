using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ConstructorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parametresiz constructorları çalıştırır.
            Sinif s = new Sinif();
            s.bilgiGöster();

            //tek parametreli constructor çalıştırır
            Sinif s1 = new Sinif(201);
            
            //iki parametreli constructor çalıştırır.
            Sinif s2 = new Sinif(201, 15);
            s2.bilgiGöster();
            Console.ReadKey();
        }
    }
}
