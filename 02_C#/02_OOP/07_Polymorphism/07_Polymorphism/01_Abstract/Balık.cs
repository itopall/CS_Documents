using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Abstract
{
    class Balık : Canlı
    {
    
        //Abstract class içerisindeki HareketEt() methodunu ezerek Balık classı içerisinde HareketEt() methoduna farklı bir işlem kazandırmış olduk 
        public override void HareketEt()
        {
            Console.WriteLine("Balık yüzüyor....");
        }

        
    }
}
