using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InterfaceSegration.DogruOrnek
{
    class PirpirNew : IAracNew
    {
        public void Calistir()
        {
            Console.WriteLine("Pirpir New çalıştı.");
        }

        public void Durdur()
        {
            Console.WriteLine("Pirpir New durdu.");
        }
    }
}
