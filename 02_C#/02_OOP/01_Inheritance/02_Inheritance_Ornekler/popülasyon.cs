using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Inheritance_Ornekler
{
    class uzuvlar
    {
        public int elsayisi;
        public int ayaksayisi;
    }
    class insan : uzuvlar
    {
        
        public void konus()
        {
            Console.WriteLine("merhaba benim {0} elim, {1} ayağım var.", elsayisi, ayaksayisi);
        }
    }
    class kopek : uzuvlar
    {
       
        public void havla()
        {
            Console.WriteLine("hav hav hav {0} elim, {1} ayağım var.", elsayisi, ayaksayisi);
        }
    }
    class kus : uzuvlar
    {
        
        public void ot()
        {
            Console.WriteLine("cik cik cik {0} elim, {1} ayağım var.", elsayisi, ayaksayisi);
        }
    }
}
