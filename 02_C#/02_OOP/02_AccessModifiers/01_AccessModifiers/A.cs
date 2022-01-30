using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AccessModifiers
{
    public class A
    {
        private int privateTip;//private yazılmasada default olarak private olur.
        public int publicTip;
        internal int internalTip;
        protected int protectedTip;
        protected internal int protectedInternalTip;

        //Aynı class içerisinde oldukları için yukarıda tanımlanan field'ların hepsine A class'ı içerisindeki herhangi bir methodun içerisinde ERİŞİLEBİLİR! 
        void Test_A()
        {
            privateTip = 10;
            publicTip = 10;
            internalTip = 10;
            protectedTip = 10;
            protectedInternalTip = 10;
        }
    }
}
