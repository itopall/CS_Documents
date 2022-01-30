using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DefaultKeyword
{
    class Program
    {
        static void Main(string[] args)
        {

            //default keyword'ü bir tipin default değerini almak için kullanılır.
            //Not: Generic değişkenlere ilk değer ataması için çok kullanışlıdır.
            int a = default(int);
            string str = default(string);
            
            Console.ReadKey();
        }
    }
}
