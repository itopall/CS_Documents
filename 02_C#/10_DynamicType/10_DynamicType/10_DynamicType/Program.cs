using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DynamicType
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dinamikTip = new Urun
            {
                Adi = "thinkpad",
                Fiyati = 10000,
                Kategorisi = "Bilgisayar"
            };

            dinamikTip.Gorunteleme();

            dinamikTip = new Musteri
            {
                Adi = "Ali",
                Soyadi = "Veli",
                DogumTarihi = new DateTime(1990,1,1)
            };
            dinamikTip.Gorunteleme();

            //Method kullanımı
            Console.WriteLine(Test("Metin deneme"));
            Console.WriteLine(Test(1000));
            Console.WriteLine(Test(DateTime.Now));

            Console.ReadKey();
        }
        static dynamic Test(dynamic deger)
        {
            return deger;
        }
    }
}
