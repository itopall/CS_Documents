using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new Random();

            //Random rnd = (Random)obj;

            //obj nesnesi Random tipindedir aşağıdaki gibi string'e cast edilmeye çalışıldığında hata atacaktır.
            //string str = (string)obj;

            //as keyword'ü cast'le işi görür ancak cast edilemediği durumda exception fırlatmak yerine null değer döner
            string str = obj as string;

            //as operatörü aşağıdaki gibi değer dürlü tipler ile kullanılamaz çünkü değer türlü tipler null alamazlar.
            //int sayi = obj as int;//value tipler de as kullanılamaz 

            Console.ReadKey();
        }
    }
}
