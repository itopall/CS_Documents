using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SealedKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.VirtualMetot();

            B b = new B();
            b.VirtualMetot();

            C c = new C();
            c.VirtualMetot();

            Console.ReadKey();

        }
    }
    class A
    {
        //virtual metot tanımlanacak
        public virtual void VirtualMetot()
        {
            Console.WriteLine("A classı tarafından yazıldı");
        }
    }
    class B : A
    {
        public sealed override void VirtualMetot()
        {
            Console.WriteLine("B classı tarafından yazıldı.");
        }
    }
    sealed class C: B
    {
        //B classı içerisnde VirtualMetot() sealed ile işaretlendiği için bu class'ta onu override edemeyiz.
        //public override void VirtualMetot()
        //{
        //}
    }
    //C classı sealed olarak işaretlendiği için D classı C'den inherit alamaz 
    //class D:C
    //{

    //}
}
