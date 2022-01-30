using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SinifİcerisndeStructBildirimi
{
    class Program
    {
        struct Ogrenci
        {
            public int OgrenciId;
            public string OgrenciAd;
            public string Ogrenci_Soyad;
            public int OgrenciNo;
        }
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.OgrenciId = 1;
            ogrenci1.OgrenciAd = "İlker";
            //Değer set etmediğimi fieldlara default değerleri atanır.
            //Struct'ın default constructorı vardır fakat biz 
            ogrenci1.Ogrenci_Soyad = "TOPAL";
            ogrenci1.OgrenciNo = 1278;
            Console.WriteLine("Öğrenci Id: {0} - Öğrenci Adı: {1} - Öğrenci Soyadı: {2} - öğrenci numarası: {3}", ogrenci1.OgrenciId, ogrenci1.OgrenciAd, ogrenci1.Ogrenci_Soyad, ogrenci1.OgrenciNo);
            Console.ReadKey();
        }
    }
}
