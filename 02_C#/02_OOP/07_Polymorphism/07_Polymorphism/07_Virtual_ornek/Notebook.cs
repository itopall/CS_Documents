using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Virtual_ornek
{
    class Notebook : Bigisayar
    {
        public bool Bluetooth  { get; set; }
        public Notebook(string marka, string cpu, int ram,bool bluetooth) : base(marka, cpu, ram)
        {
            Bluetooth = bluetooth;
        }

        

        public override void OzellikYazdir()
        {
            Console.WriteLine("Bilgisayarın markası: {0}", Marka);
            Console.WriteLine("Bilgisayarın CPU: {0}", CPU);
            Console.WriteLine("Bilgisayarın CPU: {0}", RAM);
            Console.WriteLine("Notebook'un Bluetooth özelliği : {0}", Bluetooth);
        }
    }
}
