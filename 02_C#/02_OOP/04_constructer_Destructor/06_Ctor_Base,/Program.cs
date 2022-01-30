using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Ctor_Base_
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();

            B b1 = new B(false);

            B b2 = new B(13);
            Console.ReadKey();
        }
    }
}
