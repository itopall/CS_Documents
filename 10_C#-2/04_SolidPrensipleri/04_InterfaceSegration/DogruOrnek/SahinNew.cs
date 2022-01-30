using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InterfaceSegration.DogruOrnek
{
    class SahinNew : IAracNew, IRadyoluArac
    {
        public void Calistir()
        {
            Console.WriteLine("Sahin New çalıştı.");
        }

        public void Durdur()
        {
            Console.WriteLine("Sahin New durdu.");
        }

        public void RadyoyuAc()
        {
            Console.WriteLine("Sahin New'in radyosu açıldı.");
        }
    }
}
