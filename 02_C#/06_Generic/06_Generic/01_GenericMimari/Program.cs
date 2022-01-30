using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GenericMimari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic mimari, aynı tasarımdan farklı objelerin üretilmesine imkan sağlayan C# mimarisi için ÇOK önemli bir yapıdır!
            //Generic mimari olmasaydı: Kod yazmak çok zorlaşırdı, tekrar eden kodlar artardı, tip güvenliği çok azalırdı, ileride göreceğimiz Linq yapısı diye bir şey kolay kolay olmazdı.

            //Üretilen TestSinifi nesnesinin GenericField'ının tipi int olmuştur. İlgili field'ın tipinin ne olacağı sınıf yazılırken bildirilmemesine (Generic olarak tasarlanması) rağmen nesne örneklenirken T yerine gelecek tip bildirilmiştir. 
            new TestSinifi<int>();

            //Üretilen nesnenin GenericField alanı string olarak belirtilmiştir.
            new TestSinifi<string>();

            //T yerine gelecek tip hem üretilirken hem de değişken tanımlamasında söylenmelidir!
            TestSinifi<double> obj1 = new TestSinifi<double>();
            obj1.GenericField = 10.2;
            obj1.NonGenericField = 10;

            TestSinifi<char> obj2 = new TestSinifi<char>();
            obj2.GenericField = 'b';
            obj2.NonGenericField = 20;

            TestSinifi<DateTime> obj3 = new TestSinifi<DateTime>();
            obj3.GenericField = DateTime.Now;
            obj3.NonGenericField = 30;


            //Urun Örneği;
            //T yerine int gönderildiği için Fiyat ve Kdv property'leri int tipinde çalışır
            Urun<int> urun1 = new Urun<int>(1000, 18);
            urun1.Fiyat = 1500;
            urun1.Kdv = 20;

            //T yerine double gönderildiği için Fiyat ve Kdv property'leri double tipinde çalışır
            Urun<double> urun2 = new Urun<double>(1000.5, 0.18);
            urun2.Fiyat = 1500.6;
            urun2.Kdv = 0.20;

            Console.ReadKey();
        }
    }
}
