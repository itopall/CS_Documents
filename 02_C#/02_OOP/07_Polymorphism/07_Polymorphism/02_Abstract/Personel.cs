using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstract
{
    //base class
    abstract class Personel
    {
        public string NameSurmane { get; set; }
        public int time { get; set; }
        public double price { get; set; }

        //abstract property'i sadece get methodu çalışacak şekilde oluşturduk.Drived classlarda bu property'nin get edilmesi zorunludur.
        public abstract double salary { get; }

        //Parametreli constructor
        public Personel(string _namesurname, int _time, double _price)
        {
            NameSurmane = _namesurname;
            time = _time;
            price = _price;
        }
    }
}
