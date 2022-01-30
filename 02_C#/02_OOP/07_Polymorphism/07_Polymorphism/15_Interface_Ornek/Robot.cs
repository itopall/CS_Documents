using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface_Ornek
{
    class Robot : IWorker
    {
        public int saat { get; set; }

        public void Work(int saat)
        {
            this.saat = saat;
            Console.WriteLine("Günde {0} saat çalışır.", saat);
        }
    }
}
