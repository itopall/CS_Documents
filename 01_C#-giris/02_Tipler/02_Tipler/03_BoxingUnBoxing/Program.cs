using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack'de tutulan bir değişkenin Heap'te tutulan bir değişkene (object tipinde) dönüştürülmesine box tam tersine unbox denir.
             
            int sayi = 5;
            object obj = sayi;
            //boxing işlemi
            //Ram'im solundan sağına bir aktarım gerçekleştirme.
                              
            // Sağ taraftan gelen nesne object türünde olduğu için içerisinde Int olduğundan emin değiliz başka bir tipte olabilir(Hernes bir object'tir)dolayısıyla bilinçli olarak Int'e çevrilmelidir.

            int sayi2 = (int)obj;//Unboxing 
            int sayi3 = Convert.ToInt32(obj);//Unboxing


            object obj2 = 10;
            object obj3 = "Test";
            object obj4 = true;
            object obj5 = DateTime.Now;
            object obj6 = 'b';
            //Not: Boxin unboxing işlemleri performansı olumsuz etkiler dolaysıyla gereksiz kullanımdan kaçınılmalıdır!


            Console.ReadKey();
        }
    }
}
