using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Console, Convert static class'larını namespace'e ekleyerek aşağıdaki gibi her defasında yazılmasının önüne geçebilioruz.
using static System.Console;
using static System.Convert;

namespace _09_UsingStaticClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Test");
            int sayi = Convert.ToInt32("1");


            WriteLine("Test");
            int sayi2 = ToInt32("2");
            Console.ReadKey();
        }
    }
}
