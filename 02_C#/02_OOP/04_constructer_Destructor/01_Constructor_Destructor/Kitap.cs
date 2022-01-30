using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Constructor_Destructor
{
    //Kitap class'ı newlendiğinde anda default 
    class Kitap
    {
        //prop tab'a iki kere basınca otomatik propert gelir.
        public int KitapId { get; set; }
        public string KitapAd { get; set; }
        public string KitapYazarAdi { get; set; }
        public void test()
        {
            Console.WriteLine("Test methodu çalıştı.");
        }
        public void Yazdir()
        {
            Console.WriteLine("Kitap Id: "+ KitapId + Environment.NewLine + "Kitap ad: " + KitapAd + Environment.NewLine + "Yazar adı: " + KitapYazarAdi);
        }
        //Constructor, class'tan nesne oluşturduğumuzda ilk çalışan methodtur.
        //Normalde biz yazmasakta arkada çalışan bir methoddur.
        //Referans tiplerinin null değer gelmesi, nümerik tiplerinin 0 değer gelmesi ve bool tiplerinin false değer gelmesi constructor(yapıcı) methodtan kaynaklıdır.
        //Diğer methodlardan farkı, bir veri tipi yoktur. 2.yapıcı methodun ismi class ismi ile aynıdır.
        //her class'ta sadece bir tane constructor methodu vardır.

        // Default constructor'ı değiştirmiş olduk.Artık ilk değerlerimiz farklı.
        public Kitap()
        {
            Console.WriteLine("Constructor methodu çalıştı.");
            //KitapId haricideki özelliklere değer atması yaptığımızda default yapıcı metot içerisindeki almıyor bizim aldığımız değeri alıyor.
            //KitapId'herhangi bir değer ataması yapmazsak default constructor değrini alır
            KitapId = 10;
            KitapAd = "Vadideki Zambak";
            KitapYazarAdi = "Balzac";
        }
       
    }
}
