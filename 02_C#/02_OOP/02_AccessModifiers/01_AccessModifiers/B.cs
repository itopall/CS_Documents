using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AccessModifiers
{
    class B : A
    {
        void Test_B()
        {
            //privateTip = 20; // Aclass'ından private olarak tanımlandığı için B class'ının içinde ERİŞİLEMEZ!
            publicTip = 20; //A class'ında public olarak tanımlandığı için B class'ında ERİŞİLEBİLİR!
            internalTip = 20; //A class'ında internal olarak tanımlandığı için B class'ında ERİŞİLEBİLİR!
            protectedTip = 20; //A class'ında protected olarak tanımlandığı için B class'ının içinde ERİŞİLEBİLİR
            protectedInternalTip = 20; //A class'ında protected internal olarak tanımlandığı için B class'ında ERİŞİLEBİLİR! 
        }
    }
}
