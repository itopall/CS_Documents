using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            //Push methodu,stack koleksiyonuna eleman eklemek için kullanılır
            //Stack koleksiyonunda araya eleman ekleme imkanı yoktur.Son eklenen eleman her zamna en üstte olur ve lemanlar her zaman üstten okunur.
            //Çalışma prensibi LIFO'dur. Yani son gelen eleman ilk çıkar.

            stack.Push(10);
            stack.Push("test");
            stack.Push(DateTime.Now);
            stack.Push("Deneme");
            stack.Push(5);

            //Son elemanı koleksiyondan cıkartır ve return eder.
            object sonEleman = stack.Pop();
            Console.WriteLine(sonEleman);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            //Listeden çıkarmadan sıradaki elemanı görebilmek için kullanılır.
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());

            //Koleksiyondaki elemanları ekrana yazma
            foreach (object item in stack)
                 Console.WriteLine(item);

            //Koleksiyonda test adında eleman var mı kontrol eder.
            Console.WriteLine(stack.Contains("test") ? "var": "yok");

            //Koleksiyonu temizler.
            stack.Clear();

            //InvalidOperationException: Yığın boş (Stack empty) hatası gelir.Çünkü stack'de eleman kalmamıştır.
            //Console.WriteLine(stack.Pop());

            //Stack'de elemna olmadığında Pop işlemi yaparsak hata fırlatıldığından Pop işlemi yapmadan önce stact'de eleman olup olmadığını kontrol etmekte fayda vardır.
            if (stack.Count > 0)
                Console.WriteLine(stack.Pop());
            else
                Console.WriteLine("Kuyrukta bekleyen eleman yok.");
            
            Console.ReadKey();
        }
    }
}
