using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.set_CustomerId(1);
            //değer tiplerinin default değeri 0'dır.
            int deger = c.get_CustomerId();
            Console.WriteLine("müşteri no: {0}", deger);
            Console.WriteLine(c.get_FirstName());
            c.set_LastName("topal");
            Console.ReadKey();
        }
    }
}
