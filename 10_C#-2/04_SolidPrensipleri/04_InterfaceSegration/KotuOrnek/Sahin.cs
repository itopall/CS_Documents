using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InterfaceSegration.KotuOrnek
{
    class Sahin : IArac
    {
        public void Calistir()
        {
            Console.WriteLine("Sahin çalıştı");
        }

        public void Durdur()
        {
            Console.WriteLine("Sahin durdu");
        }

        public void KlimayiAc()
        {
            Console.WriteLine("Sahin'nin kliması çalıştı");
        }

        public void RadyoyuAc()
        {
            Console.WriteLine("Sahin'nin radyosu çalıştı");
        }
    }
}
