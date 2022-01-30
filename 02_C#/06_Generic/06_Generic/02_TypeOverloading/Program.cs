using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TypeOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //int tipini kullanan bir Urun nesnesi
            Urun<int> urun1 = new Urun<int>(2500, 8);

            //int ve double tipi ile overload edilmiş versiyonu kullanan bir Urun nesnesi
            Urun<int, double> urun2 = new Urun<int, double>(1000, 0.18);

            //double ve string tipi ile overload edilmiş versiyonu kullanan bir Urun nesnesi
            Urun<double, string> urun3 = new Urun<double, string>(2000.5, "Yüzde On Sekiz");

            Console.ReadKey();
        }
    }
}
