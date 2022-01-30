using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DeclarationExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametresi kullanılırken önce değişken tanımlamamız gerekiyordu
            string date = "2020-02-29 14:14:00";
            DateTime result;
            if(DateTime.TryParse(date,out result))
                Console.WriteLine("Dönüştürme işlemi gerçekleşti..." + result);

            //Artık ekstra bir değşken tanımlamaya gerek kalmadan out parametresi kullanabiliyoruz.
            if (DateTime.TryParse(date, out DateTime result2))
                Console.WriteLine("Dönüştürme işlemi gerçekleşti..." + result2);

            Console.ReadKey();
        }
    }
}
