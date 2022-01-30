using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            //Virtual metotlar sanal metotlardır.İçleri dolu yada boş olabilir.Abstract metot,boş virtual metorlardır. Base class'da virtual anahtar kelimesi ile metodumuzu oluşturuyoruz.Sonrasında devired classlarda override etmek istersek ediyoruz.Abstract üyerigi zorunlu bir implementasyonu yoktur.

            A a = new A();
            a.virtualMethod();

            a = new B();
            a.virtualMethod();

            a = new C();
            a.virtualMethod();


            Console.ReadKey();
        }
    }
    class A
    {
        //A base classı içerisnde bir geriye değer döndürmeyen sanal metot tanımladık.
        public virtual void virtualMethod()
        {
            Console.WriteLine("bu mesaj A class'ı tarafından ekrana yazılmıştır.");
        }
    }
    class B : A
    {
        public override void virtualMethod()
        {
            Console.WriteLine("bu mesaj B classı tarafından ekrana yazılmıştır.");
            //aşağıdaki kod base classı içerisndeki sanal metodu kullandırır.
            //base.virtualMethod();
        }
    }
    class C : A
    {
        public override void virtualMethod()
        {
            Console.WriteLine("bu mesaj C classı tarafından ekrana yazılmıştır.");
        }
    }
}
