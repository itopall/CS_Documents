using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Polymorphism
{
    abstract class Canli
    {
        public abstract void HareketEt();

        public virtual void SesVer()
        {
            Console.WriteLine("Merhaba...");
        }
    }
}
