using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EnumerableSinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 5, 15, 8, 45 };

            IEnumerable<int> sorgu = sayilar.Where(p=> p > 10).Select(k => k *2);

            var list = sorgu.ToList();

            Console.ReadKey();
        }
    }
}
