using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Ctor_Base_
{
    class A
    {
        public A()
        {
            Console.WriteLine("A sınıfındaki parametresiz constructor çalıştı");
        }

        public A(bool durum)
        {
            Console.WriteLine("A sınıfındaki bool tipli parametreli constructor çalıştı.");
        }

        public A(int sayi)
        {
            Console.WriteLine("A sınıfındaki int tipli parametreli constructor çalıştı.");
        }
    }
}
