using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface_Ornek
{
    class Karga : IEtcil, IOtcul
    {
        public void BeslenmeSekli()
        {
            Console.WriteLine("Ben otçulum.");
        }

        public void beslenmeSekli2()
        {
            Console.WriteLine("Ben etçilim.");
        }

        public void canlibilgisi()
        {
            Console.WriteLine("BEnim gagam var.");
        }
    }
}
