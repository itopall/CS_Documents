using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ExpressionBodiesMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TestMethod());
            Console.WriteLine(GetTime());
            Console.ReadKey();
        }
        public static string TestMethod()
        {
            return "test.";
        }
        //Artık bu şekilde methodlar yazabiliriz.
        public static string GetTime() => "Tarih - " + DateTime.Now.ToString();
    }
}
