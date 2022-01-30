using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Virtual_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hesaplamalar base classı içerisinde 2 tane alan ve cevre hesabı yaptıran virtual method

            //derived classlar kare çember dikdörtgen olacak virtual methodları bu classlarda override edeceğiz.
            Hesaplamalar h = new Hesaplamalar();
            Kare k = new Kare();
            k.alan();
            k.Cevre();
            Dikdörtgen d = new Dikdörtgen();
            d.alan();
            d.Cevre();
            Console.ReadKey();
        }
    }
}
