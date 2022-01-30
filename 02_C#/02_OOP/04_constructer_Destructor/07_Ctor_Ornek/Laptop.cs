using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ctor_Ornek
{
    class Laptop:Urun
    {
        public double EkranBoyutu { get; set; }
        public Laptop():base()
        {
            
        }
    }
}
