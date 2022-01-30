using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Parametreli_Constructor
{
    class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string OgrenciAdSoyad { get; set; }
        public string Sinif { get; set; }
        public string Telefon { get; set; }
        public string Dogumyeri { get; set; }
        public int yas { get; set; }

        public Ogrenci(string ogrenciAdSoyad, string sinif, string Telefon)
        {
            //parametre değerlerimizi, property değerlerine eşlememiz gerek.
            OgrenciAdSoyad = ogrenciAdSoyad;
            Sinif = sinif;
            //Eğer parametre ismi ile property ismi aynı ise this anahtar kelimesi ile property'ye işaret etmiş oluyoruz.
            this.Telefon = Telefon;
            Console.WriteLine("parametreli constructor çalıştı.");
        }
        public void bilgiYazdir()
        {
            Console.WriteLine("Ad-Syoad: {0}\nÖğrenci no: {1}\nSınıf: {2}\nTelefon:{3}\nDoğum Yeri:{4}\nYas: {5}", OgrenciAdSoyad,OgrenciId, Sinif, Telefon, Dogumyeri, yas);
        }
    }
}
