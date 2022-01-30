using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Virtual_ornek
{
    class Tablet : Bigisayar
    {
        public double Inch { get; set; }
        public Tablet(string marka, string cpu, int ram,double inch) : base(marka, cpu, ram)
        {
            Inch = inch;
        }
        public override void OzellikYazdir()
        {
            
            Console.WriteLine("Bilgisayarın markası: {0}", Marka);
            Console.WriteLine("Bilgisayarın CPU: {0}", CPU);
            Console.WriteLine("Bilgisayarın CPU: {0}", RAM);
            Console.WriteLine("Tabletin inç'i: {0}", Inch);
        }
    }
}
