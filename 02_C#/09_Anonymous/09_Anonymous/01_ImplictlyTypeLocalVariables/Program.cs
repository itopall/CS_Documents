using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ImplictlyTypeLocalVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //var keyword'ü compiler'ın atmaya bkarak değişken tipine karar vermesini sağlar;
            int sayi = 10;
            var i = 10;
            var k = "test";
            var l = DateTime.Now;

            //object ile karıştırılmamalıdır. Var sağdan gelen tip ne ise tamamen o tipe göre hareket eder.Bütün özelliklerini sergiler.Object ise ayrı bir tiptir.Boxing Unboxing kuralına göre çalışır.
            object obj = sayi;//BOXING
            var a = sayi;


            //Var keyword'ü kullanılırken mutlaka değişkene ilk ataması yapılmalıdır.
            //var'ın aşağıdaki şekilde kullanımları mümkün değildir.
            //var x;
            //var y = null;//Derleme zamnında hata verir

            string z = "test";//Aşağıdakinden farkı yoktur
            var zz = "test";

            //var anahtar sözcüğü, Anonim tip yeniliğinde kullanılsın diye gelmiştir.
            //Anonim tip yeniliğ Linq sorgularında ve Entity Framework'de sıkça kullanılır.

            //var anahtar sözcüğünün iki kullanım yeri vardır
            //1) Anonim tipleri karşılamak için 
            //2) Özellikle linq'de ve Entity Framework'de gelen bazı nesnelerin tiplerin çok uzun isimlere sahip olabilmektedir.Bu isimleri kısatmak üzere kullanılabilir.(Entity Framework'de daha detaylı)


            Console.ReadKey();
        }
        //var bir tip değildir!Aşağıdaki şekilde return tipi ya da parametre tipi olarak
        //static int Deneme(int x, int y)
        //{
        //}
        class Test
        {
            public int sayi { get; set; }
            //public var text{get;set;} var bir değişken 
        }
         
    }
}
