using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface_Ornek
{
    class Aslan : IEtcil
    {
        public void beslenmeSekli2()
        {
            Console.WriteLine("Ben orman kralıyım");
        }

        public void canlibilgisi()
        {
            Console.WriteLine("benim yelelerim var.");
        }
    }
}
