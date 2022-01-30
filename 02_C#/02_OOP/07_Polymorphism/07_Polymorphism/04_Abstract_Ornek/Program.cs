using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstract_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract classtan nesne üretemeyiz.
            //Tasit t = new Tasit();
            Araba a = new Araba("Audi", "Q5", 100000, "benzin", "Otomatik");
            Console.WriteLine("Araba markası: {0} - Fiyatı: {1}", a.Marka, a.Fiyat);

            Ucak u = new Ucak("AirBus", "A-120", 900000, 100);
            Console.WriteLine("Ucak arkası: {0} - Fiyatı: {1}", u.Marka, u.Fiyat);

            Tren t = new Tren("Ada Express", "D-123", 500000, 8, "B");
            Console.WriteLine("Tren markası:{0} - Fiyatı:{1}", t.Marka, t.Fiyat);

            Gemi g = new Gemi("Gemicik", "Q-345", 60000000, 15);
            Console.WriteLine("Gemi Markası: {0} - Fiyatı: {1}", g.Marka, g.Fiyat);
            Console.ReadKey();
        }
    }
}
