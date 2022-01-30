using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwndContext context = new NorthwndContext();
            var list = context.Products.ToList();
            Console.WriteLine(list.Count);

            Console.ReadKey();
        }
    }
}
