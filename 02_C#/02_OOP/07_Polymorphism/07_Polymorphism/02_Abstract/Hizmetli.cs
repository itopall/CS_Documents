using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstract
{
    class Hizmetli: Personel
    {
        public Hizmetli(string _namesurname, int _time, double _price):base(_namesurname,_time,_price)
        {

        }

        //abstract Personel class'ı içerisindeki abstract property'i implement etmiş olduk 
        public override double salary
        {
            get
            {
                return time * price;
            }
        }
    }
}
