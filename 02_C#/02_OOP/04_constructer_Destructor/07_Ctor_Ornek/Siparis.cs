using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ctor_Ornek
{
    class Siparis
    {
        public int Id { get; set; }
        public int Adet { get; set; }
        public string Adres { get; set; }
        public double Fiyat { get; set; }

        public Siparis()
        {
            Console.WriteLine("Sipariş için gereken hazırlıklar yapılıyor.");
        }

        public Siparis(int adet,double fiyat):this()
        {
            Adet = adet;
            Fiyat = fiyat;
            Console.WriteLine(Fiyat);
            Console.WriteLine(Adet);
        }

        //constructorda yaptığımız işlemi geri almak/yıkmak için kullandığımız metottur.
        //erişim belirleyicisi yoktur.
        //Destructor tanımlaması
        ~Siparis()
        {
            Console.WriteLine("siparis class'ının destructorı çalıştı.");
        }
    }
    

}
