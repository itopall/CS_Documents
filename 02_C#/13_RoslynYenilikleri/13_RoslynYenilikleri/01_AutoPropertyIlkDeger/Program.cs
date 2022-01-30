using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AutoPropertyIlkDeger
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            //t.Ad = "Halil İbrahim";
            //t.Yas = 23;
            Console.WriteLine("{0}, {1}", t.Ad, t.Yas);


            Console.ReadKey();
        }
    }
    class Test
    {
        //İlk değer atma yeniliği sayesinde auto propert'i tanımladığımız anda değer atayabiliriz.
        public string Ad { get; set; } = "Halil İbrahim";
        public int Yas { get; set; } = 23;
    }
}
