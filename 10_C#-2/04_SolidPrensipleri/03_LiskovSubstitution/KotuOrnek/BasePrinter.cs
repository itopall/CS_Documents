using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LiskovSubstitution.KotuOrnek
{
    abstract class BasePrinter
    {
        public void Print(string value)
        {
            Console.WriteLine("Printed: {0}", value);
        }

        //Bu method türeyen bütün sınıflarda kullanılmayacağı için (Bazı yazıcılarda tarama özelliği olmayabilir) base sınıfın içinde yer almamalı. Aksi halde Liskov prensibine ters düşeriz. Base'deki bütün özellikler türeyen sınıflarda kullanılabilmeli.
        //public void Scan(string value)
        //{
        //    Console.WriteLine("Scanned: {0}", value);
        //}
    }
}
