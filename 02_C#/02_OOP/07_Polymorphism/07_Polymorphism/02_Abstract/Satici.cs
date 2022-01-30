using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstract
{
    class Satici :Personel
    {
        public int Adet { get; set; }
        public int UnitPrice { get; set; } 
        public Satici(string _namesurname, int _time, double _price, int _adet,int _unitPrice) : base(_namesurname, _time, _price)
        {
            Adet = _adet;
            UnitPrice = _unitPrice;
        }


        //Satici classı, abstract Personel base classından inherit aldığı için abstract property'İ implemente ediyoruz.
        //Satıcının maaş hesaplanırken, farklı parametre değerleri işin içerisine girdi.
        public override double salary
        {
            get
            {
                //UnitPrice değişmiyorsa ilk değeri burada da verebiliriz.
                return time * price + (Adet * UnitPrice);
            }
        }
    }
}
