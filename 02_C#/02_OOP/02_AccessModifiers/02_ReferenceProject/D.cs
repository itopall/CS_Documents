using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_AccessModifiers;

namespace _02_ReferenceProject
{
    class D : A
    {
        void Test_D()
        {   
            //privateTip = 40;
            publicTip = 40;
            //internalTip = 40; //internalTip Field'ı A class'ı 
            protectedTip = 40;
            protectedInternalTip = 40;
        }
        
    }
}
