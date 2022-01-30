using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Ctor_This
{
    class Program
    {
        static void Main(string[] args)
        {
            Deneme d = new Deneme();
            Deneme d1 = new Deneme("İlker");
            Deneme d2 = new Deneme(45);
            Console.ReadKey();
        }
    }
}
