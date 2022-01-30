using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OperatorleriAsiriYuklemek
{
    class Cizgi
    {
        public Nokta Nokta1 { get; set; }
        public Nokta Nokta2 { get; set; }

        public Cizgi(Nokta n1, Nokta n2)
        {
            Nokta1 = n1;
            Nokta2 = n2;
        }
    }
}
