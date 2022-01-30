using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ctor_Ornek
{
    class Pantolon:Urun
    {
        public string KumasTuru { get; set; }
        public Pantolon():base("pantolon")
        {

        }
    }
}
