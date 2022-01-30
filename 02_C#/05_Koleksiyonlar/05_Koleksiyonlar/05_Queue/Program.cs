using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Çalışma prensibi FIFO'dur,yani koleksiyona ilk geleln eleman ilk çıkar.
            Queue queue = new Queue();
            queue.Enqueue("ilker@gmail.com");
            queue.Enqueue("utku@gmail.com");
            queue.Enqueue("Sefa@gmail.com");
            queue.Enqueue("rumeysa@gmail.com");

            //Pop'un Queue koleksiyonundaki karşılığı olarak düşünülebilir.
            //Kuyruğa ilk giren elemanı getirir ve kuyruktan çıkartır.
            Console.WriteLine(queue.Dequeue());

            //Kuyrukta sıradaki elemanı okur ancak kuyruktan çıkarmaz
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.ReadKey();

        }
    }
}
