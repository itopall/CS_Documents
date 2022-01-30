using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_GenericKoleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic List Kullanım
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            //list.Add("test");

            foreach (int item in list)
                Console.WriteLine(item);


            //Stack Koleksiyonun Generic kullanımı. LIFO
            Stack<string> stack = new Stack<string>();
            stack.Push("Halil İbrahim");
            stack.Push("Bahadır");
            //stack.Push(10);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());


            //Queue Koelksiyonunun Generic Kullanımı. FIFO
            Queue<DateTime> queue = new Queue<DateTime>();
            queue.Enqueue(DateTime.Now);
            queue.Enqueue(DateTime.Now.AddYears(10));
            //queue.Enqueue("test");

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());


            Console.ReadKey();
        }
    }
}
