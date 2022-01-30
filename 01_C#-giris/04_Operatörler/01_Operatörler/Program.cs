using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aritmetiksel Operatörler
            //int a = 20;
            //int b = 10;
            //int c;
            //c = a + b;
            //Console.WriteLine("c: {0}", c);
            //c = a - b;
            //Console.WriteLine("c: {0}", c);
            //c = a * b;
            //Console.WriteLine("c: {0}", c);
            //c = a / b;// div ile bölme bölümü verir
            //Console.WriteLine("c: {0}", c);
            //c = a % b; // mod ile bölme kalanı verir
            //Console.WriteLine("c: {0}", c);

            //c = a++;// önce atamayı yapıp sonra a'nın değerini arttırır.
            //Console.WriteLine("c: {0}", c);

            //c = ++a;//önce a'nın değerinin arttırıp sonra atamayı yapar.
            //Console.WriteLine("c: {0}", c);

            //c = a--;// önce atamayı yapıp sonra a'nın değerini azaltır.
            //Console.WriteLine("c: {0}", c);

            //c = --a;//önce a'nın değerinin aazaltıp sonra atamayı yapar.
            //Console.WriteLine("c: {0}", c);
            #endregion

            #region Relational operatörler
            int d = 10;
            int e = 20;
            if (d == e)
                Console.WriteLine("a eşittir b");
            if (d > e)
                Console.WriteLine("d büyüktür e");
            if (d < e)
                Console.WriteLine("d küçüktür e");

            #endregion

            #region Lagical operatörler
            //bool a = true;
            //bool b = false;
            //if (a == true && b == true)
            //    Console.WriteLine("koşullar sağlandı");

            //if (a == true || b == true)
            //    Console.WriteLine("koşullarından biri sağlandı");

            //// bool tiplere özel aşağıdaki kullanım a== true ile aynıdır
            //if (a)
            //    Console.WriteLine("a'nın değeri True'dur");
            //// ilk satırda yazılmışın kısa hali
            //if (a && b)
            //    Console.WriteLine("koşullar sağlandı");

            //// ikinci satırda yazılmışın kısa hali
            //if (a || b)
            //    Console.WriteLine("koşullar sağlandı");

            //if (!(a && b))
            //    Console.WriteLine("a ve b true değil");
            #endregion

            #region Assingment Operatörler
            int a = 20;
            int b;
            b = a;
            Console.WriteLine(b);

            b += a;//b = b + a;
            Console.WriteLine(b);

            b -= a;//b = b - a;
            Console.WriteLine(b);

            b *= a;//b = b * a;
            Console.WriteLine(b);

            b /= a;//b = b / a;
            Console.WriteLine(b);

            b %= a;//b = b % a;
            Console.WriteLine(b);
            #endregion
            Console.ReadKey();
        }
    }
}
