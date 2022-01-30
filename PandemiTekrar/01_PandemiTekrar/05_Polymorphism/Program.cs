using _05_Polymorphism.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Polymorphism
            //Canli c = new Canli();
            Insan i = new Insan();
            i.HareketEt();
            i.SesVer();
            i.Yuru();
            i.Yuz();

            Kus k = new Kus();
            k.HareketEt();
            k.SesVer();
            k.Uc();
            k.Yuru();
            k.Yuz();

            Balik b = new Balik();
            b.HareketEt();
            b.SesVer();
            b.Yuz();

            //Tetikle(b);
            Tetikle(k);
            Tetikle(i);
            #endregion

            Console.ReadKey();
        }

        static void Tetikle(IYuruyebilir yuruyebilenNesne)
        {
            yuruyebilenNesne.Yuru();
        }
    }
}
