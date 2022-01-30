using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface_Ornek
{
    class Bilgisayar : IEsya
    {
        public void bilgiler()
        {
            Console.WriteLine("Ben eşyayım");
        }

        public void cansizBilgisi()
        {
            Console.WriteLine("Ben cansız bir varlığım.");
        }
    }
}
