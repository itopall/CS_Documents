using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Delegate
{
    delegate void DelegateOrnek();
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegate Kullanımı
            //DelegateOrnek d = new DelegateOrnek(OrnekMethod);
            DelegateOrnek d = OrnekMethod;

            d += OrnekMethod2;

            d += OrnekMethod2;

            //d.Invoke();
            d();
            #endregion

            #region Lambda Kullanımı
            List<int> sayilar = new List<int> { 2, 4, 1, 5, 76, 9, 12, 11 };

            //Anonim methoddan önce
            var list = sayilar.FindAll(TekMi);
            foreach (var item in list)
                Console.WriteLine(item);

            //Anonim method
            var list2 = sayilar.FindAll(delegate (int a) { return a % 2 != 0; });
            foreach (var item in list2)
                Console.WriteLine(item);

            var list3 = sayilar.FindAll(p => p % 2 != 0);
            foreach (var item in list3)
                Console.WriteLine(item);
            #endregion

            Console.ReadKey();
        }

        static void OrnekMethod()
        {
            Console.WriteLine("OrnekMethod çalıştı..");
        }

        static void OrnekMethod2()
        {
            Console.WriteLine("OrnekMethod2 çalıştı..");
        }

        static bool TekMi(int a)
        {
            return a % 2 != 0;
        }
    }
}
