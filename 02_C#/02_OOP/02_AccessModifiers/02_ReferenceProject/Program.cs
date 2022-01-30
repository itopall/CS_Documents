using _01_AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ReferenceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            //d.privateTip=40;                //privateTip'e sadece A class'ının İÇERİSİNDEN  erişilebilir.
            d.publicTip = 40;                 //
            //d.internalTip = 40;             // internalTipe'e sadece A class'ının bulunduğu proje İÇERİSİNDEN erişilebilr.
            //d.protectedTip = 40;            // protectedTipe'e sadece A class'ının ya da A classından kalıtım almış bir vir class'ın İÇERİSİNDEN erişilebilir.
            //d.protectedinternalTip = 40;    // protectedInternalTip'e sadece internal yada protected kurallarından birinin karşılandığı durumda durumda erişilebilir.

            A a = new A();
            //a.privateTip = 10;
            a.publicTip = 10;
            //a.internalTip = 10;
            //a.protectedTip = 10;
            //a.protectedInternalTip = 10;


            Console.ReadKey();
        }
    }
}
