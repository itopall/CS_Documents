using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Static_Ctor
{
    //sınıf nonstatic
    class Constructor
    {
        //static Constructor tanımladık
        static Constructor()
        {
            Console.WriteLine("Static constructor ilk çalıştı");
        }

        //nonstatic constructor tanımladık.
        public Constructor()
        {
            Console.WriteLine("non static constructor çalıştı.");
        }
    }
}
