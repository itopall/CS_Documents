using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract classlardan nesne aluşturamayız.
            //A a = new A();
            //Test t = new Test();
            //B b = new B();

            C c = new C();
            c.AbstractMethod1();
            c.AbstractMethod2();
            c.AbstractMethod3();
            Console.WriteLine("Abstract property: " + c.AbstractProperty1);
            c.AbtractOlmayanMethod();
            Console.ReadKey();
        }
    }
    //test --> A --> B --> C
    abstract class Test
    {
        //geriye değer döndürmeyen abstract method oluşturmuş olduk
        public abstract void AbstractMethod1();

        //Abstract property tanımlama
        public abstract int AbstractProperty1 { get; }

        //Geriye değer döndürmeyen method tanımlama
        public void AbtractOlmayanMethod()
        {
            Console.WriteLine("Her class da aynı çalışır.");
        }

    }
    //A adında abstract bir class oluşturduk.Test abstract classından inherit alırdık.
    abstract class A : Test
    {
        //abstract method tanımlama 
        public abstract void AbstractMethod2();
    }
    abstract class B : A
    {
        public abstract void AbstractMethod3();

        public override void AbstractMethod1()
        {
            Console.WriteLine("Test class'ı içerisindeki AbstractMethod1'i B class'ı implemente etmiş oldu.");
        }
        //public override void AbstractMethod2()
        //{
        //    Console.WriteLine("A class'ı içerisndeki AbstractMethod2'yi B class'ı implemente etmiş oldu.");
        //}
    }
    class C : B
    {
        public override int AbstractProperty1 => throw new NotImplementedException();

        //B calssı içerisinde , sadece AbstracMethod1'i override ettiğimiz için ve c classsı B'den inherit aldığı için tekrardan override etme zorunluluğumuz yok.
        //Ama AbstractMethod2() ile AbstractMethod3() override edilmediği için burada override etme zorunlulumuz var
        public override void AbstractMethod2()
        {
            Console.WriteLine("AbstractMethod2 methodu C sınıfında değiştirilmiştir.");
        }

        public override void AbstractMethod3()
        {
            Console.WriteLine("AbstractMethod3 methodu C sınıfında değiştirilmiştir.");
        }
    }
}
