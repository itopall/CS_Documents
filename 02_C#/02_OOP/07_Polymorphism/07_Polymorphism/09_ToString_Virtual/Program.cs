using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ToString_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToStirng() metodu object classı içerinde virtual olarak oluşturulmuştur
            object obj = "";
            Console.WriteLine(obj.ToString());

            //int Tipi object'ten gelen toString metodu override ederek kendisine özel bir davranış kamıştır.(polmorfik bir yapı oluyor.)
            //Tüm veri tipleri için  burada aynı durum geçerlidir.

            //Int32 struct classı içerisinde virtual olan ToString metodu override edilmiştir.
            int sayi = 4;
            Console.WriteLine(sayi.ToString());
            //Boolean struct classı içeirisinde virtual olan ToString metodu override edilmiştir.
            bool durum = true;
            Console.WriteLine(durum.ToString());

            //DateTime struct içerisnde virtual olan ToString metodu override edilmiştir.
            DateTime tarih = new DateTime();
            Console.WriteLine(tarih.ToString());


            Console.ReadKey();
        }
    }
}
