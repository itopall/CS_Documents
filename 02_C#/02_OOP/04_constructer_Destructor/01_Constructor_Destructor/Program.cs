using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Constructor_Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap k = new Kitap();
            //k.KitapId = 1;
            //k.KitapAd = "Suç ve Ceza";
            //k.KitapYazarAdi = "Dostoyevski";
            //k.test();

            //Yazdır() methodu kitap classında yapmayarak da burada yazdırma işlemi yapabiliriz.Böylelikle k.KitapId dediğimizde get methodu çalışır.
            //Console.WriteLine("kitap ıd: {0}", k.KitapId);
            //kendi oluşturduğumuz metotları birden fazla çağırabilir fakat constructor sınıfından nesne oluştuğu için anda bir kez çalışır.
            k.Yazdir();

            //Class'yeni nesne üretildiğinde constructor methodu çalışır.
            Kitap k1 = new Kitap();
            k1.KitapId = 2;
            k1.KitapAd = "Doria Gray portresi";
            k1.KitapYazarAdi = "Ocar Wilde";
            k1.Yazdir();
            Console.ReadKey();
        }
    }
}
