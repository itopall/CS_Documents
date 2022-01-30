using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EzilmisDavranis
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun(1,"Laptop",10000);

            Console.WriteLine(urun.ToString());

            //GetHashCode Kullanımı
            Urun urun2 = new Urun(2, "Klavye", 100);
            Urun urun3 = new Urun(2, "Klavye", 100);

            Console.WriteLine(urun2.GetHashCode());
            Console.WriteLine(urun3.GetHashCode());

            //if (urun2.GetHashCode() == urun3.GetHashCode())
            //    Console.WriteLine("İki ürün eşittir");
            //else
            //    Console.WriteLine("İki ürün eşit değildir.");

            //Equal kullanımı
            Console.WriteLine(urun2.Equals(urun3) ? "Eşittir":"Eşit değildir.");


            Console.ReadKey();
        }
    }
}
