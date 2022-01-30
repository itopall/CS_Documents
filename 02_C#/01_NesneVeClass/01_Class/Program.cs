using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tanımlana class üzerinden aşağıdaki şekilde field'lara ya da methodlara erişemeyiz!
            //Ogrenci.yas;
            //Ogrenci.bolum;
            //Ogrenci.BolumDegistir();
            //Ogrenci.YasumDegistir();

            //Class üzerinden oluşturulan nesne üzerinden (ogr) field ve methodlara erişim sağlayabiliriz.
            Ogrenci ogr = new Ogrenci();
            ogr.BolumDegistir("Makina");
            ogr.YasDegistir(25);
            Console.WriteLine("Yaş: {0}", ogr.yas);
            Console.WriteLine("Bölüm: {0}", ogr.bolum);

            // new Ogrenci(); => bu yöntemin adına nesne üretmek(instance almak ya da new'lemek de denir.)

            Ogrenci ogr2 = new Ogrenci();
            ogr2.BolumDegistir("Elektronik");
            ogr2.YasDegistir(23);
            Console.WriteLine("Yaş: {0}", ogr2.yas);
            Console.WriteLine("Bölüm: {0}", ogr2.bolum);

            Ogretmen ogretmen = new Ogretmen();
            ogretmen.ogretmenAdi = "Ekrem";
            ogretmen.YoklamaAl(8);
            Console.WriteLine("Öğretmen Adı: {0}, Öğrenci Sayısı: {1}", ogretmen.ogretmenAdi, ogretmen.OgrenciSayisi);

            Ogretmen ogretmen2 = new Ogretmen();
            ogretmen2.ogretmenAdi = "Osman";
            ogretmen2.YoklamaAl(12);
            Console.WriteLine("Öğretmen Adı: {0}, Öğrenci Sayısı: {1}", ogretmen2.ogretmenAdi, ogretmen2.OgrenciSayisi);




            Console.ReadKey();
        }
    }

    class Ogrenci
    {
        //class'ların içerisinde field(değişken),method ve property'ler tanımlanabilir.
        public int yas = 20;
        public string bolum = "Yazılım";

        public void BolumDegistir(string yeniBolum)
        {

            bolum = yeniBolum;
        }

        public void YasDegistir(int yeniYas)
        {
            yas = yeniYas;
        }
    }

    class Ogretmen
    {
        public int OgrenciSayisi;
        public string ogretmenAdi;

        public void YoklamaAl(int sayi)
        {
            OgrenciSayisi = sayi;
        }
    }



}
