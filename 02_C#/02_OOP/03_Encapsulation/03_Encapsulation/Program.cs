using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product();
            product.set_id(100);
            Console.WriteLine(product.get_id());

            product.set_price(5000);
            Console.WriteLine(product.get_price());
            //Exception Management uygulayarak Product sınıfında fırlattığımız hataları yakalayıp programın kesilmesini engelledik.Hatayı mesaj olarak kullanıcıya gösterdik. 
            try
            {
                product.set_id(1000);
                Console.WriteLine(product.get_id());

                product.set_price(-5);
                Console.WriteLine(product.get_price());
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);

            }
            
            Console.ReadKey();
        }
    }
}
