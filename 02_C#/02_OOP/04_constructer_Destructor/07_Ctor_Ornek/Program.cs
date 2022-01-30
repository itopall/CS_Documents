using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ctor_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            #region this() örnek

            //this() anahtar sözcüğü için örnek.
            //Sipariş adında bir class oluşturalım, içerisinde Id,Adet,Adres, Fiyat property'leri olsun.
            //2 farklı ctor tanımlayalım,biri hiç parametre almasın,diğeri Adet, Fiyat propertylerini parametre olarak alsın 
            //ancak parametere almayan ctor içerisinde ekrana "Sipariş için gereken hazırlıklar yapılıyor" yazsın.
            //parametere alan ctor aynı yazıyı tekrar etmeden ekrana yazdırabilsin.

            Siparis s = new Siparis();

            Siparis s1 = new Siparis(17,5.27);

            #endregion

            //Urun adında bir base class oluşturalım, bu base class'tan türeyen Laptop ve pantolan adında iki class daha oluşturalım.
            //Laptop'un içinde EkranBoyutu adında,Pantolonun içinde ise KumasTuru Adında birer property olsun.
            //laptop calss'ında bir nesne ürettiğimizde Urun class'ındaki ctor ile ekrana "Laptop için nesne üretildi" yazsın 
            //Aynı şekilde Pantolon için nesne üretildiğinde "pantolan için nesne üretildi" yazsın .

            Laptop l = new Laptop();
            l.EkranBoyutu = 15.6;
            Console.WriteLine("Ekran boyutu: {0} inç", l.EkranBoyutu);

            Pantolon p = new Pantolon();
            p.KumasTuru = "Kadife";
            Console.WriteLine("Pantolonun kumaş türü: {0}", p.KumasTuru);
            Console.ReadKey();
        }
    }
}
