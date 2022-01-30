using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftwareDeveloper s = new SoftwareDeveloper();
            s.Eat();
            s.Work(10);
            s.Salary();

            Manager m = new Manager();
            m.Eat();
            m.Work(10);
            m.Salary();

            Robot r = new Robot();
            r.Work(24);
          

            Console.ReadKey();
        }
    }
}
