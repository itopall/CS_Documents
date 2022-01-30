using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Abstract
{
    //Base classımızı abstract class olarak oluşturacağız.
    abstract class Canlı
    {
        //Abstract metotların içerisi boş olmak zorundadır.
        //Virtual methodun içerisinin boş hali olarakta tanımlayabiliriz.
        //Abstract classlar içerisinde hem abstract methodlar hemde normal metotlar tanımlanabilir.
        //Abstract classlardan nesne üretemiyoruz.
        //private olarak abstract metotları oluşturamayız.

        public abstract void HareketEt();

        //public abstract void Add();

        //public abstract void Delete();

        //public abstract void Update();

        //normal metot tanımlaması yapılabilir.
        public void Add2()
        {
            Console.WriteLine("Add2 methodu çalıştı");
        }
    }
}
