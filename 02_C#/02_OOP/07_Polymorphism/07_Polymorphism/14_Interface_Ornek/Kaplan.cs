using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface_Ornek
{
    //Sadece IEtcil interfacesinden implemente edildi.IEtcil'de ICanli interfacesinden implemente 
    class Kaplan : IEtcil
    {
        public void beslenmeSekli2()
        {
            Console.WriteLine("ben etçil beslenirim.");
        }

        public void canlibilgisi()
        {
            Console.WriteLine("Sivri dişlerim vardır.");
        }
    }
}
