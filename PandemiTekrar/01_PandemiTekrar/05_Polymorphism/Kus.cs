using _05_Polymorphism.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Polymorphism
{
    class Kus : Canli, IYuz, IYuruyebilir, IUcabilir
    {
        public override void HareketEt()
        {
            Console.WriteLine("Kus uçuyor...");
        }

        public override void SesVer()
        {
            Console.WriteLine("Cik cik...");
        }

        public void Uc()
        {
            Console.WriteLine("Kuş kanatlarıyla uçuyor...");
        }

        public void Yuru()
        {
            Console.WriteLine("Kuş sekerek yürüyor...");
        }

        public void Yuz()
        {
            Console.WriteLine("Kuş yüzüyor...");
        }
    }
}
