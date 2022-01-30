using _05_Polymorphism.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Polymorphism
{
    class Insan : Canli, IYuruyebilir, IYuz
    {
        public Insan()
        {
            Console.WriteLine("Insan nesnesi üretildi...");
        }

        public Insan(int yas) : this() //Base class'daki ctor'a yönlendirmek istersek base() keyword'ünü kullanabiliriz.
        {
        }

        public override void HareketEt()
        {
            Console.WriteLine("Insan yürüyor...");
        }

        public override void SesVer()
        {
            base.SesVer();
        }

        public void Yuru()
        {
            Console.WriteLine("İnsan iki ayak üzerinde yürüyor...");
        }

        public void Yuz()
        {
            Console.WriteLine("İnsan kulaç atarak yüzüyor...");
        }
    }
}
