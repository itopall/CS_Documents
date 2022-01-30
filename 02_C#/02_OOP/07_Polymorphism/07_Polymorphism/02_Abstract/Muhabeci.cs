using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstract
{
    class Muhabeci : Personel
    {
        public Muhabeci(string _namesurname, int _time, double _price):base(_namesurname,_time,_price)
        {

        }

        //Personel sınıfındaki, sadece get methodu olan absract property'i implemente ettik. Yani derived class'ta(Muhasebeci) tekrardan biçimlerdirdik.
        public override double salary
        {
            get
            {
                
                return time * price;
            }
        }
    }
}
