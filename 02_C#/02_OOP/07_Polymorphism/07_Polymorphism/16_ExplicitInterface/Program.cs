using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ExplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aynı metot ve propertyleri içeren iki tane Interface aynı sınıfa implemente ettiğimiz durumlarda explicit interface'i kullanmak zorunda kalırız.
            Insan insan = new Insan();
            //Insan calass içerisinde HareketEt() metodu private olduğu için instance'dan metoda ulaşamayız.
            //insan.HareketEt();

            //Bu metoda ulaşabilmek için metodun tanımlandığı yer olan interface tipinde kullanılmaktadır.

            //İnsan nesnesini IHareketEdebilircs interfacesine cast ederek metoda erişebildik.
            ((IHareketEdebilircs)insan).HareketEt();
            ((IYuruyebilir)insan).HareketEt();

            //Aşağıdaki şekildede kullana biliriz.
            //IHareketEdebilircs insan2 = new Insan();
            //insan2.HareketEt();
            //IYuruyebilir yuruyebilir = new Insan();
            //yuruyebilir.HareketEt();


            Console.ReadKey();
        }
    }
}
