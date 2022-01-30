using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Thread
{
    //Tek bir program akışı içerisinde birden fazla işlemin gerçekleştirilmesi Thread sınıfıyla mümkündür. Şu ana kadar yaptığımız bütün örnekler ana program akışını takip ederek yapmaları beklenen görevleri sırayla gerçekleştiriyordu. Thread (iş parçacığı) kullanımı, birden fazla işlemin tek bir akışı paylaşarak neredeyse eşzamanlı bir şekilde gerçekleşmesini sağlar.
    class Program
    {
        static void Main(string[] args)
        {
            SingleThreading singleThreading = new SingleThreading();
            singleThreading.StartSingleOperations();

            MultipleThreading multipleThreading = new MultipleThreading();
            multipleThreading.StartMultipleOperations();

            Console.ReadKey();
        }
    }
}
