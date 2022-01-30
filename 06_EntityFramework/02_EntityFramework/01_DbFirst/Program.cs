using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities context = new NORTHWNDEntities();

            var allProducts = context.Products.ToList();
            //foreach (var product in allProducts)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            var product2 = context.Products.Where(p => p.ProductID == 1).FirstOrDefault();
            Console.WriteLine(product2.ProductName);

            Console.ReadKey();
        }
    }
}
