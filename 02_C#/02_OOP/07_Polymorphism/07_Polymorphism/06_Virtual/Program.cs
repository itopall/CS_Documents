using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            HesapIslemleri hesap = new HesapIslemleri();
            hesap.ParaGonder(1000);
            Console.WriteLine(hesap.virtualMethod());

            hesap = new Havale();
            hesap.ParaGonder(200);
            Console.WriteLine(hesap.virtualMethod());

            hesap = new EFT();
            hesap.ParaGonder(500);
            Console.WriteLine(hesap.virtualMethod());

            hesap = new Swift();
            hesap.ParaGonder(400);
            Console.WriteLine(hesap.virtualMethod());

            Console.ReadKey();
        }
    }
}
