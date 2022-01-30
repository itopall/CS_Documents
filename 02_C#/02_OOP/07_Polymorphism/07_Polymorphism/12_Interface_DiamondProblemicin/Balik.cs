using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interface_DiamondProblemicin
{
    class Balik:IYüzebilir
    {
        //Interfaceler Inheritanc mantığıylada kullanılır.

        public void Yuz()
        {
            Console.WriteLine("Balık yüzgeçleriyle yüzer.");
        }
    }
}
