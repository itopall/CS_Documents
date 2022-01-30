using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InterfaceSegration.KotuOrnek
{
    class Bmw : IArac
    {
        public void Calistir()
        {
            Console.WriteLine("Bmw çalıştı");
        }

        public void Durdur()
        {
            Console.WriteLine("Bmw durdu");
        }

        public void KlimayiAc()
        {
            Console.WriteLine("Bmw'nin kliması çalıştı");
        }

        public void RadyoyuAc()
        {
            Console.WriteLine("Bmw'nin radyosu çalıştı");
        }
    }
}
