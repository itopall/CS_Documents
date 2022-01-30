using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_NullOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = null;
            if (a != null)
            {
                Console.WriteLine(a.Name);
            }
            else
                Console.WriteLine("A null'dır");

            //Yukarıdaki null kontrolünü artık aşağıdaki gibi yapabiliriz.
            Console.WriteLine(a?.Name);

            A a2 = new A();
            
            Console.WriteLine(a2?.Name);


            Console.ReadKey();
        }
    }
    class A
    {
        public string Name { get; set; } = "Test";
    }
}
