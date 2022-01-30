using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ctor_Ornek
{
    class Urun
    {
        public Urun()
        {
            Console.WriteLine("Laptop için nesne üretildi");
        }
        public Urun(string metin )
        {
            Console.WriteLine("Pantolon için nesne üretildi.");
        }
    }
}
