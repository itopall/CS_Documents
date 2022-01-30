using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Static_MetinBoslukRakamTemizleme
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "İlker asda 14 352 sada fas 3412";
            string result = stringHelper.BoslukVeRakamTemizle("İlker asda 14 352 sada fas 3412");
            Console.WriteLine("Metinden boşluk ve rakamların temizlenmiş hali: {0}", result);
            Console.WriteLine("Metin : {0}", metin);
            Console.ReadKey();
        }
    }
}
