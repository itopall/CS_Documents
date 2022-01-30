using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Virtual_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bişgisayar adında bir base class oluşturunuz
            //Propertyleri : Marka - CPU - RAM
            //parametreli constructor olacak
            //OzellikYazdir() adında bir virtual metot olacak 

            //derived class Notebook ve Tablet adında oluşturunuz
            //Notebook classı için ayrıca Bluetooth özelliğini oluşturunuz.
            //Tablet için ise Inch propertysinin oluşturunuz.
            //Derived classlarda OzellikYazdir() methodunu override edeceğiz.

            Bigisayar b = new Bigisayar("dell", "intel", 4);
            b.OzellikYazdir();

            Tablet t = new Tablet("Samsung","intel",8,15.6);
            t.OzellikYazdir();

            Notebook n = new Notebook("Mac", "CPU1", 8, false);
            n.OzellikYazdir();

            Console.ReadKey();
        }
    }
}
