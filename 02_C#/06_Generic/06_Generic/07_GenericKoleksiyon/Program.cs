using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_GenericKoleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tip Güvenliği Sorunu
            ArrayList words = new ArrayList();
            words.Add("Test-1");
            words.Add("Test-2");
            words.Add("Test-3");
            words.Add("Test-4");

            //ArrayList object'lerle çalıştığı için, parametre olarak 10 gönderildiğinde compiler buna kızmaz
            words.Add(10);

            //ArrayList'in Add methodu object parametre alacak şekilde tasarlanmıştır. Böylece ArrayList'lerde string'ler de int'ler de, kısaca her tipden nesne saklanabilir. Int'de bir object olduğundan dolayı Add çağrısı compile zamanında hata üretmeyecektir.

            //Bu ekranda şu anda hatalı kodlar görmemize rağmen, compiler bu hataları bulamaz! Çünkü yazılan ArrayList tasarımına göre, bu ekranda görülen tüm kodlar Teorik olarak doğrudur! Ancak çalışma zamanında hata meydana gelecektir!
            //foreach (string word in words)
            //    Console.WriteLine(word);
            #endregion

            #region Performans Sorunu
            ArrayList sayilar = new ArrayList();
            sayilar.Add(5); //BOXING
            sayilar.Add(10); //BOXING
            sayilar.Add(20); //BOXING

            int ikinciSayi = (int)sayilar[1]; //UNBOXING

            //Object'lerle çalışma aslında gerçekten gereksinim yoksa, ZARARLIDIR!
            //1) tip güvenliği sorunu
            //2) Performans sorunu
            //3) Gereksiz cast işlemleri

            //Tüm bu sebepler performansı iki taraflı düşürür!
            //1) Programcının performansını
            //2) Programın performansını
            #endregion

            #region Generic List Kullanımı
            KendiListem<int> yeniSayilar = new KendiListem<int>();
            yeniSayilar.Add(10); //BOX olmaz!

            //Derleme zamanında hata alır! Tip güvenliği sağlandı. Sadece int değerler eklenebilir.
            //yeniSayilar.Add("Test");

            KendiListem<string> yeniKelimeler = new KendiListem<string>();
            yeniKelimeler.Add("Test"); //BOX olmaz!

            //Derleme zamanında hata alır! Tip güvenliği sağlandı. Sadece string değerler eklenebilir.
            //yeniKelimeler.Add(10);

            KendiListem<object> arrayListeBenzerKullanim = new KendiListem<object>();
            arrayListeBenzerKullanim.Add(5); //Boxing var ama kendi kontrolümüzde yaptık.
            arrayListeBenzerKullanim.Add("Test");

            //.Net içerisindeki List<> tipi
            List<int> zatenYazilmisBirListVar = new List<int>();
            zatenYazilmisBirListVar.Add(5);
            zatenYazilmisBirListVar.Add(10);

            Console.WriteLine(zatenYazilmisBirListVar[1]);

            List<string> stringList = new List<string>();
            stringList.Add("test");
            stringList.Add("test2");
            #endregion

            Console.ReadKey();
        }
    }
}
