using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Static_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pi sayısı:{0}",Static_class.Pi);
            Static_class.staticMethod();
            Static_class.staticProperty = 14;
            Console.ReadKey();
        }
    }
}
