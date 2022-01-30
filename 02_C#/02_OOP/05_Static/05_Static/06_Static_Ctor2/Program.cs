using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Static_Ctor2
{
    class Program
    {
        static void Main(string[] args)
        {
            NonStaticClass.staticProperty1 = 10;
            NonStaticClass.staticProperty2 = 15;

            NonStaticClass n = new NonStaticClass();

            n.nonStaticProperty1 = 20;
            n.nonStaticProperty2 = 25;

            StaticClass.nonStaticBilgi(n);
            StaticClass.staticBilgi();
            Console.ReadKey();
        }
    }
}
