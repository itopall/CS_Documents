using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //private: Sadece o class içerisinden erişilebilir
            //public: Her yerden erişilebilir.
            //internal: Aynı proje içerisinden erişilebilir.
            //protected: Tanımlandığı tip ve o tipden kalıtılmış tiplerin İÇERİSİNDEN erişilebilir.
            //protected internal: internal ya da protected koşullarından biri sağlanırsa erişilebilir.

            A a = new A();
            //a.protectedTip = 1; //Sadece sınıfın içerisinden erişilebilir!

            B b = new B();
            //b.protectedTip = 10; //Sadece sınıfın içerisinden erişilebilir!

            Console.ReadKey();
        }

        class A
        {
            protected int protectedTip;

            //Aynı class içerisinde olduğu için protectedTip'e erişilebildi. 
            private void TipKullan()
            {
                protectedTip = 10;
            }
        }

        class B : A
        {
            private void TipKullanB()
            {
                protectedTip = 20;
            }
        }
    }
}
