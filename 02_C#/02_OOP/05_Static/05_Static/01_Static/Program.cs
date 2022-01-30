using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static anahtar kelimesini kullandığımız tüm metodlar, tüm propertyler, tüm classslar nonstatic yapılardır.
            //Static property ,static method ,static constructor, static class

            //nonstatic metotlara ve propertylere biz nesne üreterek ulaşırız.
            //Fakat Static metot ve propertylere nesne üretmeden derekt sınıf isminden ulaşıyoruz.

            Matematik.sayi1 = 1;
            Matematik.sayi2 = 4;

            //static metotlara ulaştık.
            Matematik.topla();
            Matematik.carp();
            Matematik.cikar();
            Matematik.bolme();

            //nonstatic method olduğu için nesne üretmemiz  gerekir. 
            Matematik m = new Matematik();
            m.yaz();
            Console.ReadKey();
        }
    }
}
