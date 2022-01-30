using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Struct_IlkDegerAtama
{
    struct Customer
    {
        //Yapılarada field oluştururken ilk değer atamasını da yapmakk istersek hata verir.fakat static tanımlarsak hatayı çözmüş oluruz.
        public static int CustomerId = 1;
        public static string CustomerName = "İlker";
        static void Main(string[] args)
        {
            Customer c = new Customer();
            //tanımladığımız fieldlar static old. için nesneden ulaşamıyoruz.
            //Console.WriteLine(c.CustomerName);
            //Console.WriteLine(c.CustomerId);
            //Tanımladığımız fieldlar static old. için structtan ulaşabiliyoruz.
            Console.WriteLine(Customer.CustomerName);
            Console.WriteLine(Customer.CustomerId);

            Console.ReadKey();
        }
    }
}
