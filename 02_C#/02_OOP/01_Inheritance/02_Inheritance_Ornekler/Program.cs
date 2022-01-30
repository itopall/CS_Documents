using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Inheritance_Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region örnek 1
            //Müdür ve Yaziilimci adında iki tane Class oluşturalım. Id,AdSoyad, Maas ve mudure özel Bölge yazılımcıya özel Proje field'larını Kalıtım'a en uygun şekilde tasarlayalım.
            //MudurBilgileriniYazdiri YazilimciBilgileriniYazdir, CalisanAdiniYazdir methodlarınıda ekleyelim.
            //MudureAit mudur = new MudureAit();
            //mudur.id = 4;
            //mudur.AdSoyad = "ali veli";
            //mudur.Maas = 7.566;
            //mudur.bolge = "marmara";
            //mudur.MudureAitBilgiler();
            //mudur.CalisanAdiniYazdir();
            /////////\\\\\\\\
            //YazilimciyeAit yazilimci = new YazilimciyeAit();
            //yazilimci.id = 5;
            //yazilimci.Maas = 4.265;
            //yazilimci.AdSoyad = "numan dallas";
            //yazilimci.proje = "kafe otomasyonu";
            //yazilimci.YazilimciyaAitBilgiler();
            //yazilimci.CalisanAdiniYazdir();
            #endregion

            #region örnek 2
            //Manav, Sebze, Meyve Class'larımız olsun. Id,Ad,Fiyat,Kg YemekTuru,MeyveSuyu gibi Field'ları Kalıtıma en uygun şekilde Classların içerisine dağıtalım
            //Meyveler meyveler = new Meyveler();
            //meyveler.Id = 4;
            //meyveler.ad = "vişne";
            //meyveler.fiyat = 3.5;
            //meyveler.kg = 1.5;
            //meyveler.meyvesuyu = "vişne suyu";
            //meyveler.MeyveSuyunuYazdır();
            ////---------------------------------------\\
            //Sebzeler sebzeler = new Sebzeler();
            //sebzeler.Id = 3;
            //sebzeler.ad = "pırasa";
            //sebzeler.fiyat = 2.75;
            //sebzeler.kg = 3;
            //sebzeler.yapılanyemek = "pırasa";
            //sebzeler.YemegiYazdir();
            #endregion

            #region örnek 3
            insan insan = new insan();
            insan.elsayisi = 2;
            insan.ayaksayisi = 2;
            insan.konus();

            kopek kopek = new kopek();
            kopek.elsayisi = 0;
            kopek.ayaksayisi = 4;
            kopek.havla();

            kus kus = new kus();
            kus.elsayisi = 0;
            kus.ayaksayisi = 2;
            kus.ot();
            #endregion

            Console.ReadKey();
        }
    }
    class Ortakkesim
    {
        public int id;
        public string AdSoyad;
        public double Maas;
        public void CalisanAdiniYazdir()
        {
            Console.WriteLine("çalışan adı: {0}", AdSoyad);
        }
        
    }

    class MudureAit : Ortakkesim
    {
        public string bolge;
        public void MudureAitBilgiler()
        {
            Console.WriteLine("müdür Id: {0}, müdür adı soyadı: {1}, müdürün maaşı: {2}, müdürün bölgesi:{3} ",id,AdSoyad,Maas,bolge);
        }
    }

    class YazilimciyeAit : Ortakkesim
    {
        public string proje;
        public void YazilimciyaAitBilgiler()
        {
            Console.WriteLine("yazılımcı Id: {0}, yazılımcı adı soyadı: {1}, yazılımcı maaşı: {2}, yazılımcı projesi:{3} ", id, AdSoyad, Maas, proje);
        }
    }
    
    
}
