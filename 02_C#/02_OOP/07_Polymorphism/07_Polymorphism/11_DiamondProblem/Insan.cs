using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DiamondProblem
{
    //Insan da hem YuruyenNesne hemde YuzenNesnedir çoklu kalıtım yapamayız.
    class Insan : YuruyenNesne//,YuzenNesne
    {
        public override void Yuru()
        {
            Console.WriteLine("İnsan iki ayakları üzerinde yürür.");
        }
    }
}
