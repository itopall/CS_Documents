using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AccessModifiers
{
    //C# içerisindeki bütün tip ve üyelere access modifier verilmek zorundadır! Verilmediği taktirde default olarak arka planda (private olarak ) belirlenir.
    //Sadece class'lara özel default erişim belirleyicisi internal olarak belirlenir.
    class Program
    {
        static void Main(string[] args)
        {
            //private: yalnızca tanımlanan tip İÇERİSİNDEN erişilebilir.
            //public = Hiçbir kısıtlaması yoktur, her yerden erişilebilir.
            //internal = aynı proje içerisinden erişilebilir.
            //protected: Tanımlandığı tip ve o tipten kalıtışmış tiplerin İÇERİSiNDEN erişilebilir.
            //protected internal : internal ya da protected erişim belirleyicisinden birine uyulduğu taktirde erişilebilir.

            A a = new A();
            //a.privateTip = 10; //privateTip'e sadece A class'ın içerisinden erişilebilir.
            a.publicTip = 10;
            a.internalTip = 10;
            //a.protectedTip = 10; //protectedTip'e sadece A class'ından yada A class'ından kalıtım alan class'ların İçerisinden erişilebilir.
            a.protectedInternalTip = 10;
            B b = new B();
            //b.privateTip = 20;
            b.publicTip = 20;
            b.internalTip = 20;
            //b.protected = 20;
            b.protectedInternalTip = 20;

            C c = new C();
            //c.privateTip = 30;
            c.publicTip = 30;
            c.internalTip = 30;
            //c.protected = 30;
            c.protectedInternalTip = 30;

            Console.ReadKey();
        }
    }
}
