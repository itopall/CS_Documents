using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localdegiskenvenuldeger
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Değer türlü değişken
            int c = 20;
            {
                int a = 20;
                int b = 10;
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            Console.WriteLine(c);
            #endregion
            #region
            //Değer türlüler null almazlar.
            //Null değer almak referans türlü bir değişken Heap'teki hiçbir nesneyi işaret etmemesidir.

            string kelime = "test";// Ram'in sağ tarafında bir nesneyi işaret ediyor.
            kelime = null;//Ram'in sağ tarafında hiç bir nesneyi işaret etmiyor.

            //Null ReferaeceException: Referans Türlü bir değişkenin null olması durumunda hiçbir üyesine erişilemez!!
            //kullanmaya çalışıldığında NullReferenceException alınır!
            Console.WriteLine();
            #endregion



            Console.ReadKey();
        }
    }
}
