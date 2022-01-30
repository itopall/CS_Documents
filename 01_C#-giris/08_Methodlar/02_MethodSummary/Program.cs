using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MethodSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            //summary blokları methodları kullanacak developer'lara methodun ne iş yaptığına dair bilgi vermek amacıyla kullanılır.
            Console.WriteLine();

            //summary bloğu olmayan methodlarda herhangi bir açıklama gözükmez
            AciklamasizMethod();

            //summary bloklarının içerisinde yazanlar açıklama olarak methodun üstüne gelindiğinde yada yazım aşamasında parantez açıldığında görülebilir.
            AciklamaliMethod();

            //Her bir parametrenin içinde açıklama tanımlanabilir.
            int sonuc = topla(1, 2);
            Console.ReadKey();
        }
        static void AciklamasizMethod()
        {
            Console.WriteLine("AciklamasizMethod");
        }

        /// <summary>
        /// bu method ekrana "Aciklamali method çalıştı..." mesajı yazar
        /// </summary>
        static void AciklamaliMethod()
        {
            Console.WriteLine("AciklamaliMethod çalıştı...");
        }

        /// <summary>
        /// Girilen iki sayının toplamını alıp return eder 
        /// </summary>
        /// <param name="sayi1">Toplama işlemi için gereken 1. sayı</param>
        /// <param name="sayi2">Toplama işlemi için gereken 2. sayı</param>
        /// <returns></returns>
        static int topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
