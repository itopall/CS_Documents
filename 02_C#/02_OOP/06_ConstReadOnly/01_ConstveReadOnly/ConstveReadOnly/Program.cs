using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstveReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            //const alanlarına class ismi ile direkt ulaşılabilir.
            Console.WriteLine(ConstTest.PiSayisi);
            Console.WriteLine(ConstTest.E);

            ReadOnlyTest r = new ReadOnlyTest();
            //Aşağıdaki kod hatalı yazımdır.
            //r.YalnızOkunanDeger = 90;
            Console.WriteLine(r.YalnızcaOkunanDeger2);

            Console.ReadKey();

        }
    }
}
