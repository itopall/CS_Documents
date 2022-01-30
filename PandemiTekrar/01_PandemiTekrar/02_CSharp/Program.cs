using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class ve Nesne
            Sinif s = new Sinif();
            new Sinif();

            s.Adi = "202";
            s.AdDegistir("203");
            #endregion

            #region Kalıtım
            Personel p = new Personel();
            p.Id = 1;
            p.AdSoyad = "Ali Veli";

            Mudur m = new Mudur();
            m.Id = 2;
            m.AdSoyad = "Hasan Hüseyin";
            m.Bolge = "Marmara";
            m.MaasHesapla(20);

            TemizlikGorevlisi tg = new TemizlikGorevlisi();
            tg.Id = 3;
            tg.AdSoyad = "Ayşe Fatma";
            tg.SorumluOlduguKat = 4;
            tg.MaasHesapla(30);

            #endregion

            Console.ReadKey();
        }

        //Class Tanımı
        class Sinif
        {
            public string Adi = "201";

            public void AdDegistir(string yeniAd)
            {
                Adi = yeniAd;
            }
        }

        class Personel
        {
            public int Id;
            public string AdSoyad;
        }

        class Mudur : Personel
        {
            public string Bolge;
            public double Maas;
            public void MaasHesapla(int calisilanGun)
            {
                //Hesaplama mudure özel yapılır.
            }
        }

        class TemizlikGorevlisi : Personel
        {
            public int SorumluOlduguKat;
            public double Maas;
            public void MaasHesapla(int calisilanGun)
            {
                //Hesaplama TemizlikGorevlisi'ne göre yapılır.
            }
        }
    }
}
