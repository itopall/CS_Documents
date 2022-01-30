using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InterfaceSegration.DogruOrnek
{
    class BmwNew : IAracNew, IKlimaliArac, IRadyoluArac
    {
        public void Calistir()
        {
            Console.WriteLine("Bmw New çalıştı.");
        }

        public void Durdur()
        {
            Console.WriteLine("Bmw New durdu.");
        }

        public void KlimayiAc()
        {
            Console.WriteLine("Bmw New'in kliması açıldı.");
        }

        public void RadyoyuAc()
        {
            Console.WriteLine("Bmw New'in radyosu açıldı.");
        }
    }
}
