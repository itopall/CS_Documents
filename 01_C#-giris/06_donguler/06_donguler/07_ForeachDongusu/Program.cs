using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Foreach döngüsü ve string dizisi kullanımı
            //string[] stringDİzi = { "Sefa", "Berat", "Rumeysa", "İlker", "Utku" };
            //foreach (string item in stringDİzi)
            //    Console.WriteLine(item);
            #endregion

            #region Foreach döngüsü ve int dizisi
            //int[] intDizi = { 5, 10, 20, 6, 78, 64, 3, 42 };
            //foreach (int sayi in intDizi)
            //    Console.WriteLine(sayi);
            #endregion

            #region foreach döngüsü ve string kullanımı
            //string cumle = "ali ata bak";
            //foreach (char karakter in cumle)
            //{
            //    if (karakter == ' ')
            //        Console.WriteLine();
            //    else
            //        Console.Write(karakter);
            //}
            #endregion

            #region foreach döngüsü ile continue ve nreak kullanımı
            //int[] intDizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int sayi in intDizi)
            //{
            //    if (sayi == 5 || sayi == 6)
            //        continue;
            //    if (sayi == 8)
            //        break;
            //    Console.WriteLine(sayi);
            //}
            #endregion

            #region iç içe foreach döngüsü kullanımı
            //int[] carpimTablosuDizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int item in carpimTablosuDizi)
            //{
            //    foreach (int item2 in carpimTablosuDizi)
            //        Console.WriteLine("{0} * {1} = {2} ", item, item2, item * item2);
            //}
            #endregion

            Console.ReadKey();
        }
    }
}
