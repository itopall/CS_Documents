using _11_Ornekler.Ornek1;
using _11_Ornekler.Ornek2;
using _11_Ornekler.Ornek3;
using _11_Ornekler.Ornek4.Business;
using _11_Ornekler.Ornek4.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            //Generic Swap işlemi yapan bir class tasarlayalım. İçerisindeki Swap methodu ile parametre olarak aldığı iki değişkenin değerlerini değiştirip ikisini birden geri dönsün

            //int a = 10;
            //int b = 20;
            //Swap swap = new Swap();
            //swap.SwapMethod<int>(ref a, ref b);
            //Console.WriteLine("a: {0}, b: {1}", a,b);

            //string c = "test1";
            //string d = "test2";
            //swap.SwapMethod(ref c, ref d);
            //Console.WriteLine("c: {0}, d: {1}", c, d);
            #endregion

            #region Örnek 2
            //Bir tane Generic sınıf oluşturalım ve 2 ayrı tip alsın (T, K). İçerisinde GenericProperty1 ve GenericProperty2 property'leri olsun, birinin tipi T diğerinin ise K olsun ve bu değerler class'dan nesne üretildiğinde belirtilmek zorunda olsun.
            //Class'ın içerisinde bir tane de Reset methodu olsun ve bu method çağrıldığında her iki property'de default değerlerine dönsün

            //GenericClass<int, string> genericClass = new GenericClass<int, string>(100, "test");

            //Console.WriteLine(genericClass.GenericProperty1);
            //Console.WriteLine(genericClass.GenericProperty2);

            //genericClass.Reset();

            //Console.WriteLine(genericClass.GenericProperty1);
            //Console.WriteLine(genericClass.GenericProperty2);
            #endregion

            #region Örnek 3
            //Bir tane Icecek adında instanse'ı alınamayan class oluşturalım ve bu class'tan türeyen Ayran, Kola, MeyveSuyu gibi class'larımız olsun. Ek olarak bir tane Bardak class'ı oluşturalım, içerisinde Genislik, Yukseklik property'leri ve Generic olarak Doldur adında bir method olsun. Bu method sadece Icecek tipindeki değerleri parametre olarak alabilsin ve methodun içinde Tip bilgisi + " dolduruldu" mesajı string olarak return edilsin.

            //Bardak bardak = new Bardak();
            //Console.WriteLine(bardak.Doldur<Ayran>(new Ayran()));

            //bardak = new Bardak();
            //Console.WriteLine(bardak.Doldur<Kola>(new Kola()));

            //bardak = new Bardak();
            //Console.WriteLine(bardak.Doldur<MeyveSuyu>(new MeyveSuyu()));
            #endregion

            #region Örnek 4
            //Bir tane Ogrenci class'ı oluşturalım içerisinde Id, AdSoyad, Sinif property'leri olsun
            //Bir tane Ogretmen class'ı oluşturalım içerisinde Id, AdSoyad, Eğitimler property'leri olsun
            //OgrenciIslemleri class'ı oluşturalım içerisinde OgrenciListesi property'si (List<Ogrenci>) ve Ekle, Sil, ListeyiGetir methodları olsun.
            //OgretmenIslemleri class'ı oluşturalım içerisinde OgretmenListesi property'si (List<Ogretmen>) ve Ekle, Sil, ListeyiGetir methodları olsun
            //Sonuc adında bir class oluşturalum içerisinde Mesaj, BasariliMi ve Data property'leri olsun. Data property'sinin tipi generic olacak. 
            //OgrenciIslemleri ve OgretmenIslemleri class'larındaki Ekle, Sil ListeyiGetir methodlarının hepsinin return tipi Sonuc class'ı tipinde olacak. Sonuc class'ının içindeki Data property'si içerisinde sonuçlar dönülecek. 
            //İşlem başarılıysa BasariliMi property'si true değilse false olarak dönecek
            //Mesaj kısmı da "İşlem başarıyla tamamlandı" ya da "Hata oluştu, Hata detayı: ex.message" şeklinde bilgi dönecek.

            #region Öğrenci İşlemleri
            OgrenciBusiness ogrenciBusiness = new OgrenciBusiness();

            //Öğrenci Ekleme
            OgrenciDto ogrenci1 = new OgrenciDto();
            ogrenci1.Id = 1000;
            ogrenci1.AdSoyad = "Ömer Kargın";
            ogrenci1.Sinif = "Yazılım Uzmanlığı";

            Sonuc<bool> sonuc = ogrenciBusiness.Ekle(ogrenci1);
            Console.WriteLine(sonuc.Mesaj);

            OgrenciDto ogrenci2 = new OgrenciDto();
            ogrenci2.Id = 1001;
            ogrenci2.AdSoyad = "Halil İbrahim Çakır";
            ogrenci2.Sinif = "Yazılım Uzmanlığı";

            Sonuc<bool> sonuc2 = ogrenciBusiness.Ekle(ogrenci2);
            Console.WriteLine(sonuc2.Mesaj);

            //Öğrenci Silme
            Sonuc<bool> sonuc3 = ogrenciBusiness.Sil(ogrenci2);
            Console.WriteLine(sonuc3.Mesaj);

            //Listeyi Getir
            Sonuc<List<OgrenciDto>> sonuc4 = ogrenciBusiness.ListeyiGetir();
            if (sonuc4.BasariliMi)
            {
                Console.WriteLine(sonuc4.Mesaj + "\r\n");

                foreach (OgrenciDto ogrenci in sonuc4.Data)
                {
                    Console.WriteLine("Id: {0}\r\nAdSoyad: {1}\r\nSinif: {2}\r\n", ogrenci.Id, ogrenci.AdSoyad, ogrenci.Sinif);
                }
            }
            else
            {
                Console.WriteLine(sonuc4.Mesaj);
            }
            #endregion

            #region Öğretmen İşlemleri
            OgretmenBusiness ogretmenBusiness = new OgretmenBusiness();

            //Öğrenci Ekleme
            OgretmenDto ogretmen1 = new OgretmenDto();
            ogretmen1.Id = 1000;
            ogretmen1.AdSoyad = "Ekrem Öztürk";
            ogretmen1.Egitimler = "Yazılım Uzmanlığı, Sql";

            Sonuc<bool> sonuc5 = ogretmenBusiness.Ekle(ogretmen1);
            Console.WriteLine(sonuc5.Mesaj);

            OgretmenDto ogretmen2 = new OgretmenDto();
            ogretmen2.Id = 1001;
            ogretmen2.AdSoyad = "Osman Körhasan";
            ogretmen2.Egitimler = "Solidworks";

            Sonuc<bool> sonuc6 = ogretmenBusiness.Ekle(ogretmen2);
            Console.WriteLine(sonuc6.Mesaj);

            //Öğrenci Silme
            Sonuc<bool> sonuc7 = ogretmenBusiness.Sil(ogretmen2);
            Console.WriteLine(sonuc7.Mesaj);

            //Listeyi Getir
            Sonuc<List<OgretmenDto>> sonuc8 = ogretmenBusiness.ListeyiGetir();
            if (sonuc8.BasariliMi)
            {
                Console.WriteLine(sonuc4.Mesaj + "\r\n");

                foreach (OgretmenDto ggretmen in sonuc8.Data)
                {
                    Console.WriteLine("Id: {0}\r\nAdSoyad: {1}\r\nEğitimler: {2}\r\n", ggretmen.Id, ggretmen.AdSoyad, ggretmen.Egitimler);
                }
            }
            else
            {
                Console.WriteLine(sonuc8.Mesaj);
            }
            #endregion

            #endregion

            Console.ReadKey();
        }
    }
}
