using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic Kullanımı
            Product<int> p1 = new Product<int>(100, 18);
            Product<double> p2 = new Product<double>(100, 0.18);

            Product<int, double> p3 = new Product<int, double>(100, 0.18);

            p3.OrnekMethod<int>(100);
            p3.OrnekMethod(100);
            #endregion

            #region Kısıtlamalar
            new SadecePersonel<Personel>();
            new SadecePersonel<GeneralManager>();
            //new SadecePersonel<int>();
            new SadeceGeneralManager<GeneralManager>();
            //new SadeceGeneralManager<Personel>();
            new Orneklenebilenler<Personel>();
            new Orneklenebilenler<GeneralManager>();
            //new Orneklenebilenler<Orneklenemeyen>();
            new InterfaceZorunlu<InterfaceImplementEden>();
            //new InterfaceZorunlu<Personel>();
            new BirdenFazlaParametreAlan<Personel, Test, InterfaceImplementEden>();
            #endregion

            #region Koleksiyonlar
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            //list.Add("deneme");

            foreach (var item in list)
                Console.WriteLine(item);

            //Stack
            Stack<string> stack = new Stack<string>();
            stack.Push("Deneme 1");
            stack.Push("Deneme 2");
            stack.Push("Deneme 3");
            stack.Pop();
            stack.Pop();
            stack.Peek();

            //Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Dequeue();
            queue.Dequeue();
            queue.Peek();
            #endregion

            #region Sözlük Tabanlı Generic Koleksiyon
            SortedList<int, string> sehirler = new SortedList<int, string>();
            sehirler.Add(34, "İstanbul");
            sehirler.Add(53, "Rize");
            sehirler.Add(35, "İzmir");

            Console.WriteLine(sehirler[34]);

            foreach (KeyValuePair<int, string> s in sehirler)
            {
                Console.WriteLine($"Key: {s.Key}, Value: {s.Value}");
            }

            Dictionary<int, string> sehirler2 = new Dictionary<int, string>();
            sehirler2.Add(34, "İstanbul");
            sehirler2.Add(53, "Rize");
            sehirler2.Add(35, "İzmir");

            foreach (KeyValuePair<int, string> s in sehirler2)
            {
                Console.WriteLine($"Key: {s.Key}, Value: {s.Value}");
            }
            #endregion

            Console.ReadKey();
        }
    }

    class Orneklenemeyen
    {
        private Orneklenemeyen()
        {
        }
    }

    class InterfaceImplementEden : IEnumerable, IComparable
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    struct Test : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
