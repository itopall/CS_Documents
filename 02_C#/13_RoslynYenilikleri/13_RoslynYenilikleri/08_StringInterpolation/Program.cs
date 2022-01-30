using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Rümeysa";
            int age = 23;

            Console.WriteLine("{0} - {1}",name,age);

            //Artık string formatlama işlemlerini aşağıdaki şekilde yapabiliriz.
            Console.WriteLine($"{name} - {age}");
            Console.ReadKey();
        }
    }
}
