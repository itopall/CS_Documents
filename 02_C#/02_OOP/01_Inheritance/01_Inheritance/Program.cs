using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kalıtım(Inheritance):Farklı tiplerde kullanılabilecek ortak özelliklerin (aşağıdaki gibi Id,UrunAd ve Fiyat Field'ları)tek bir ana class'da toplaması ve diğer class'ları bu ana class'tan türetilerek kendi içlerinde bu alanları tekrardan yazmak zorunda kalmaması demektir.

            Urun urun = new Urun();
            urun.id = 4;
            urun.UrunAd = "Logitech mouse";
            urun.Fiyat = 50.0;
            urun.FiyatiYazdir();

            Laptop laptop = new Laptop();
            laptop.id = 5;
            laptop.UrunAd = "Monster";
            laptop.Fiyat = 5.999;
            laptop.EkranBoyutu = "15 inch";
            laptop.LaptobuServiseGonder();
            laptop.FiyatiYazdir();

            Araba araba = new Araba();
            araba.id = 9;
            araba.UrunAd = "BMW 3.20";
            araba.Fiyat = 420.500;
            araba.YakitTuru = "Dizel";
            araba.VitesTuru = "otomatik";
            araba.FiyatiYazdir();
            araba.YuzbinBakiminaGonder();

        }
    }

    //urun sınıfı bir base class(ortak, ana sınıf) olarak tasarlandı.Diğer sınıflar tarafından ortak olarak  kullanılan Id,UrunAd ve fiyat field'ları bu sınıf içerisinde oluşturuldu.
    class Urun
    {
         public int id;
         public string UrunAd;
         public double Fiyat;
         public void FiyatiYazdir()
        {
            Console.WriteLine("fiyat: {0}", Fiyat);
        } 
    }
    //Laptop sınıfı Urun sınıfından kalıtım aldığı için Id,UrunAd ve Fiyat alanları otomatik olarak kalıtım aldığı Urun sınıfından geliyor .Dolayısıyla Laptop sınıfı içerisinde tekrar yazmaya gerek kalmıyot.
    //Laptop sınıfı içerisinde sadece Laptop'a özel olan alanlar eklenebilir (aşağıda EkranBoyutu alanı Laptopa'a özel olarak eklendi).
    //Kalıtım alma yöntemi: "SınıfAdı : kalıtım alınacak Sınıf"
    class Laptop : Urun
    {
        public string EkranBoyutu;
        public void LaptobuServiseGonder()
        {
            Console.WriteLine("Laptop yetkili servise gönderildi...");
        }
    }

    //Laptop için yazılan notlar Araba için de Geçerlidir.Araba sınıfına özel olarak VitesTuru ve YakitTuru alanları eklendi. 
    class Araba : Urun
    {
        public string VitesTuru;
        public string YakitTuru;
        public void YuzbinBakiminaGonder()
        {
            Console.WriteLine("Araba Yüz bin bakımına gönderildi...");
        }
    }
}
