using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_Mutex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giriş yapıldı...");

            bool check;
            Mutex mutex = new Mutex(true, "Program", out check);
            if (!check)
            {
                Console.WriteLine("Bu program zaten çalışıyor...");
                Thread.Sleep(10000);
                return;
            }

            Console.ReadKey();
        }
    }
}
