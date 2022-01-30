using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface_Ornek
{
    class Manager : ISalary, IWorker, IEat
    {
        public double salary
        {
            get;
            set;
        } = 2000;
        public int saat
        {
            get;
            set;
        }

        public void Eat()
        {
            Console.WriteLine("Müdür iskender yer.");
        }

        public void Salary()
        {
            Console.WriteLine("Manager {0} TL maaş alıyor.", salary);
        }

        public void Work(int saat)
        {
            this.saat = saat;
            Console.WriteLine("Günde {0} saat çalışıyor.", saat);
        }
    }
}
