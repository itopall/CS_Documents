using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Virtual
{
    class HesapIslemleri
    {
        public virtual void ParaGonder(int miktar)
        {
            Console.WriteLine("{0} tutarında para havale edilmiştir.", miktar);
            
        }
        public virtual int virtualMethod()
        {
            return 1;
        }
    }
}
