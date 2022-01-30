using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Static
{
    class Matematik
    {
        public static int sayi1 { get; set; }
        
        //Static anahtar sözcüğünün erişim belirleyicisinden sonra yada önce olması fark etmez.
        static public int sayi2 { get; set; }

        static public int sonuc { get; set; }

        //static method tanımlaması yapalım
        //geriye int tipinde değer döndüren static method tanımladık
        public static int topla()
        {
            sonuc = sayi1 + sayi2;
            return sonuc; 
        }
        public static int cikar()
        {
            sonuc = sayi1 - sayi2;
            return Math.Abs(sonuc);
        }
        public static int carp()
        {
            sonuc = sayi1 * sayi2;
            return sonuc; 
        }
        public static int bolme()
        {
            if (sayi1 >= sayi2)
            {
                sonuc = sayi1 / sayi2;
                return sonuc;
            }
            else
            {
                sonuc = sayi2 / sayi1;
                return sonuc;
            }
        }
        //classımız static olmadığı için içerisinde nonstatic metot ve propertyler oluşturabiliriz.
        //Static olmayan classlarda hem static hemde nonstatic metot propertyleri oluşturabiliriz.
        public void yaz()
        {
            Console.WriteLine("Nonstatic class içerisinde nonstatic metod tanımlaması yapabiliriz.");
        }

        //static constructor oluşturalım.
        //Static constructorların erişim belirleyicileri yoktur.
        //Sadece nesne ürettiğimiz static üye static constructor'dır.
        static Matematik()
        {
            Console.WriteLine("Statik constructor metodu çalıştı.");
        }

        //Bir Classda eğer hem nonstatic ctor hem de static ctor varsa static ctor ilk önce çalışır.
        //sonrasında nonstatic ctor çalışır.
        public Matematik()
        {
            Console.WriteLine("nonstatic constructor methodu çalıştı.");
        }
    }
}
