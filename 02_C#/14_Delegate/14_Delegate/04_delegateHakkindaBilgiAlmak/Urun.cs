using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_delegateHakkindaBilgiAlmak
{
    class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public Urun(int id,string ad, double fiyat)
        {
            Id = id;
            Ad = ad;
            Fiyat = fiyat;
        }

        public void ZamYap(double zamOran)
        {
            Fiyat += Fiyat * zamOran;
        }

        public static void Test(double sayi)
        {
            Console.WriteLine($"Gelen sayı: {sayi}");
        }
    }
}
