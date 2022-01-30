using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Ctor_Base_
{
    class B:A
    {
        //base() anahtar sözcüğü ile A sınıfındaki parametresiz constructorı çağırmış olduk
        public B():base()
        {

        }
        //base(durum ) anahtar sözcüğü ile A sınıfındaki bool tipindeki parametreli cons. çağırmış olduk.
        public B(bool durum): base(durum)
        {

        }

        //base(sayi) anahtar sözcüğü ile A sınıfındaki int tipindeki parametreli cons çağırmış olduk
        public B(int sayi):base(sayi)
        {

        }
    }
}
