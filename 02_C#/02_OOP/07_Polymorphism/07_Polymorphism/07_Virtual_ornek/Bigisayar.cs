using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Virtual_ornek
{
    class Bigisayar
    {
        public string Marka { get; set; }
        public string CPU { get; set; }
        public int RAM { get; set; }

        public Bigisayar(string marka,string cpu,int ram)
        {
            Marka = marka;
            CPU = cpu;
            RAM = ram;
        }
        public virtual void OzellikYazdir()
        {
            Console.WriteLine("Bilgisayarın markası: {0}",Marka);
            Console.WriteLine("Bilgisayarın CPU: {0}",CPU);
            Console.WriteLine("Bilgisayarın CPU: {0}",RAM);
        }
    }
}
