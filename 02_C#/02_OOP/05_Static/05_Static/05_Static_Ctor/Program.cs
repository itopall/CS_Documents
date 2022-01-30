using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Static_Ctor
{
    class Program
    {
        static void Main(string[] args)
        {
            //hem static hemde nonstatic constructor'ı çalıştırmak için new anahtar sözcüğü ile classtan nesne oluşturmak yeterli olur.
            //Tek nesne oluşturularak çalışan static üye static constructordır.

            //static constructor ilk  önce çalışır, nonstatic constructor sonrasında çalışır.
            Constructor c = new Constructor();
            


            Console.ReadKey();
        }
    }
}
