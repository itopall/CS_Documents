using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _04_DinamikUyeCagirmak
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FieldInfo
            //Console.WriteLine("Erişmek istediğiniz field adınız giriniz: ");
            //FieldInfo fi = typeof(Matematik).GetField(Console.ReadLine());
            //Console.WriteLine(fi.GetValue(null));
            #endregion

            #region Private alana erişim
            FieldInfo fi2 = typeof(Matematik).GetField("_gizliAlan", BindingFlags.Static | BindingFlags.NonPublic);

            Console.WriteLine(fi2.GetValue(null));
            fi2.SetValue(null, 10000);
            Console.WriteLine(fi2.GetValue(null));
            #endregion

            Console.ReadKey();
        }
    }

    static class Matematik
    {
        public static double Pi = 3.14;
        public static double Kdv = 0.18;
        private static int _gizliAlan = 10;
    }
}
