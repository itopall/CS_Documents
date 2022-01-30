using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_NesneVeClassOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Örnek-1
            //Bir tane okul Class'ı oluşturalım,içerisinde OgrenciSayisi,OgretmenSayisi,DerslikSayisi field'ları olsun.Bu field'lar için aşağıdaki methodları yazalım.
            //OgrenciEkle,OgrenciCikar
            //OgretmenEkle,OgretmenCikar
            //DerslikEkle,DerslikCikar

            //Okul class'ından bir nesne üreterek bütün methodları kullanıp son sayıları ekrana yazdıralım.
            

            //Farklı bir dosya içerisinde de class oluşturabiliriz.Okul class'ı farklı bir dosya oluşturuldu.
            Okul okul = new Okul();
            #endregion

            #region Örnek-2
            //Bir tane Urun Class'ı oluşturalım.İçerisinde UrunAdi,UrunFiyati,UrunKategorisi field'ları olsun. Bir tane UrunOlustur methodu ekleyelim ve ad,fiyat,kategori alanlarını parametre olarak kalsın. Gelen değerleri ilgili field'lara aktarsın. Ek olarak Urun fiyatı 0 ve 0'dan küçük olması durumunda uyarı verip işlemi gerçekleştirmesin.

            #endregion

            #region Örnek-3
            // ETicaret adında süreç class'ı oluşturalım. İçerisinde aşağıdaki field ve methodlar olsun.
            //Field'lar:SepettekiUrunAdi,SepettekiUrunFiyati,SepettekiUrunKategorisi,SiparisDurumu,KargoTakipNumarası
            //Methodlar: SepeteUrunEkle,SiparisVer,SiparisKargola,SiparisTeslimEdildiYap
            #endregion
            Console.ReadKey();
        }
    }


}
