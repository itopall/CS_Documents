using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interface_DiamondProblemicin
{
    class Insan : IYuruyebilir, IYüzebilir
    {
        //Diamond problemleri intefaceleri kullanarak çözmüş olduk. Birden fazla interface  implemente ederk Kus classında hem Yuz() metoduna hemde Yuru()  metoduna polimorfik bir yapı kazandırmış olduk
        public void Yuru()
        {
            Console.WriteLine("İnsan iki ayağı üzerinde yürür.");
        }

        public void Yuz()
        {
            Console.WriteLine("İnsan farklı skills ile yüzebilir.");
        }
    }
}
