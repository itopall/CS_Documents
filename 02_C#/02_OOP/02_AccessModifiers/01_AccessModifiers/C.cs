using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AccessModifiers
{
    // kalıtım yoluyla B class'ına gelen her üyeye C class'ında da erişilebilir.
    class C:B
    {
        void Test_C()
        {
            //c.private =   20;
            publicTip = 30;
            internalTip = 30;
            protectedTip = 30;
            protectedInternalTip = 30;
        }
      
    }
}
