using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Struct_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Koordinatlar adında bir struct oluturacayız içerisinde x ve y değerlerini alan field oluşturunuz. İki parametreli constructor tanımlayınız.Hem struct içerisinde ilk değer ataması yapıp,hemde main metodu içerisinde değişkene ilk atamasını yaparak oluşturunuz.

            //Kullanım 1
            //Koordinatlar k = new Koordinatlar();
            //k.x = 2;
            //k.y = 3;
            //Console.WriteLine("X koordinat değeri: {0}",k.x);
            //Console.WriteLine("Y koordinat değeri: {0}",k.y);

            //kullanım 2 için çağrım şekli struct isminden static olan field ulaştık.
            Console.WriteLine(Koordinatlar._x);
            Console.WriteLine(Koordinatlar._y);
            Console.ReadKey();
        }
    }
}
