using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface_Ornek
{
    class Inek : IOtcul
    {
        public void BeslenmeSekli()
        {
            Console.WriteLine("İnekler otla beslenir.");
        }

        public void canlibilgisi()
        {
            Console.WriteLine("İnekler dört bacaklıdır ve geviş getirir.");
        }
    }
}
