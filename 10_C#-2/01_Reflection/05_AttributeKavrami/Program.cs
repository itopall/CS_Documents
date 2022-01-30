using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AttributeKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] nitelikler = typeof(Product).GetCustomAttributes(true);
            Console.WriteLine(((LanguageAttribute)nitelikler[0]).Name);

            object[] nitelikler2 = typeof(Personel).GetCustomAttributes(true);
            Console.WriteLine(((LanguageAttribute)nitelikler2[0]).Name);

            Console.ReadKey();
        }
    }
}
