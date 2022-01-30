using _05_Polymorphism.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Polymorphism
{
    class Balik:Canli, IYuz
    {
        public override void HareketEt()
        {
            Console.WriteLine("Balik yüzüyor...");
        }

        public override void SesVer()
        {
            Console.WriteLine("Konuşamam...");
        }

        public void Yuz()
        {
            Console.WriteLine("Balık yüzgeçleriyle yüzüyor...");
        }
    }
}
