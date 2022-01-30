using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Static_Ctor2
{
    class NonStaticClass
    {
        //2 tane nonstatic property taanımladık
        public int nonStaticProperty1 { get; set; }
        public int nonStaticProperty2 { get; set; }

        //2 tane static property tanımladık
        public static int staticProperty1 { get; set; }
        public static int staticProperty2 { get; set; }

        //non static constructor tanımladık
        public NonStaticClass()
        {
            Console.WriteLine("Non static constructor çalıştı.");
        }

        //static constructor tanımladık
        static NonStaticClass()
        {
            Console.WriteLine("Static constructor çalıştı.");
        }
    }
}
