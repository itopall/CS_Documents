using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DiamondProblem
{
    //Kus hem UcanNesne hemde YuruyenNesne'ye giriyor.Fkata çoklu kalıtımı C# desteklemediği için iki sınıftan da inherit alamayız.Derleme zamanında hata alırız.

    class Kus : UcanNesne//,YuruyenNesne
    {
        public override void Uc()
        {
            Console.WriteLine("kuş kanatlarıyla uçar.");
        }
    }
}
