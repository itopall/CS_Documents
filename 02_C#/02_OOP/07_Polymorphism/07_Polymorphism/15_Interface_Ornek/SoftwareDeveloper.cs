using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface_Ornek
{
    class SoftwareDeveloper : ISalary, IWorker, IEat
    {
        public double salary
        {
            get;
            set;
        } = 1000;
     

        public void Salary()
        {
            Console.WriteLine("{0} TL maaş alır.", salary);
        }

        public void Eat()
        {
            Console.WriteLine("yazılımcı yemek yer.");
        }

        public int saat { get; set; } 
        public void Work(int saat)
        {
            this.saat = saat;
            Console.WriteLine("Günde {0} saat çalışır.", saat);
        }
    }
}
