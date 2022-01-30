using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interface_DiamondProblemicin
{
    class Kus: IYuruyebilir, IUcabilir
    {
        //Diamond problemleri intefaceleri kullanarak çözmüş olduk. Birden fazla interface  implemente ederk Kus classında hem Uc() metoduna hemde Yuru()  metoduna polimorfik bir yapı kazandırmış olduk

        //Override yazmaz fakat override işlemi yapmış oluruz.

        public void Uc()
        {
            Console.WriteLine("Kuş kanatlarıyla uçar.");

        }
        public void Yuru()
        {
            Console.WriteLine("Kuş seke seke yürür.");
        }
    }
}
