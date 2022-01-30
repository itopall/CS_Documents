using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Static_Ctor2
{
    class StaticClass
    {
        //Parametre olarak,class'tan değişken üretip de kullanabiliriz.
        public static void nonStaticBilgi(NonStaticClass nesne)
        {
            //NonStaticClass'ı non static old.için nesne adındaki değişkenden propertylere ulaşabiiliriz.
            Console.WriteLine("NonStaticProperty: {0}", nesne.nonStaticProperty1);
            Console.WriteLine("NonStaticProperty: {0}", nesne.nonStaticProperty2);
        }
        public static void staticBilgi()
        {
            Console.WriteLine("StaticProperty1: {0}", NonStaticClass.staticProperty1);
            Console.WriteLine("StaticProperty2: {0}", NonStaticClass.staticProperty2);
        }
    }
}
