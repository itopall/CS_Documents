using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ExplicitInterface
{
    class Insan : IYuruyebilir, IHareketEdebilircs
    {
        void IHareketEdebilircs.HareketEt()
        {
            Console.WriteLine("İnsan hareket edebilir.");
        }

        //explicit implemente edildiğinde gelen üyeler pirvatedir. Ve zorunluluktur.
        void IYuruyebilir.HareketEt()
        {
            Console.WriteLine("İnsan yürüyor.");
        }
    }
}
