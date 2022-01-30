using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;
            int d;
            //a,b,c değişkenleri yukarıda kullanıldığı için aşağıda tekrar kullanılamaz!
            // int a = 10, b = 20, c = 30; //tek satırda birden fazla değişken tanımlanabilir.

            //string tipimde değişken tanımlama.
            string stringTest = "Deneme";
            string stringTest2;

            //char tipinde değişken tanımlama , içerisinde sadece tek bir karakter saklayabilir.
            char charTest = 'A';

            //bool tipinde değişken tanımlama, sadece true ya da false değerleri saklayabilir.
            bool boolTest = true;// false'da atayabiliriz.

            //Tarih (DataTime) tipinde değişken tanımlama.
            DateTime bugun = DateTime.Now;

            //Bir değişkendeki değeri diğer bir değişkene atama 
            int e = a;

            Console.WriteLine("Value Type'lar - stack (Ram'in sol bölgesi)");
            Console.WriteLine("byte: min: " + byte.MinValue + " - max: " + byte.MaxValue);
            Console.WriteLine("sbyte: min: " + sbyte.MinValue + " - max: " + sbyte.MaxValue);
            Console.WriteLine("int: min: " + int.MinValue + " - max: " + int.MaxValue);
            Console.WriteLine("uint: min: " + uint.MinValue + " - max: " + uint.MaxValue);
            Console.WriteLine("short: min: " + short.MinValue + " - max: " + short.MaxValue);
            Console.WriteLine("ushort: min: " + ushort.MinValue + " - max: " + ushort.MaxValue);
            Console.WriteLine("long: min: " + long.MinValue + " - max: " + long.MaxValue);
            Console.WriteLine("ulong: min: " + ulong.MinValue + " - max: " + ulong.MaxValue);
            Console.WriteLine("float: min: " + float.MinValue + " - max: " + float.MaxValue);
            Console.WriteLine("double: min: " + double.MinValue + " - max: " + double.MaxValue);
            Console.WriteLine("decimal: min: " + decimal.MinValue + " - max: " + decimal.MaxValue);
            Console.WriteLine("char: min: " + char.MinValue + " - max: " + char.MaxValue);
            Console.WriteLine("boll: min: " + bool.TrueString + " - max: " + bool.FalseString);
            Console.WriteLine("DateTime: min: " + DateTime.MinValue + " - max: " + DateTime.MaxValue);

            Console.WriteLine();
            Console.WriteLine("Referans Type'lar - Heap(Ram'in sağ bölgesi)");
            Console.WriteLine("object");
            Console.WriteLine("string");





            Console.ReadKey();
        }
    }
}
