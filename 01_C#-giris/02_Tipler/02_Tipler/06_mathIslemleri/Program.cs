using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_mathIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pi saysı: {0}", Math.PI);
            Console.WriteLine("En küçük: {0}", Math.Min(20,50));
            Console.WriteLine("En büyük: {0}", Math.Max(20, 50));

            double sayi = 3;

            Console.WriteLine("Yuvarlama: {0}", Math.Round(sayi));//Tam sayıya yuvarlama 
            Console.WriteLine("Yuvarlama: {0}", Math.Round(sayi, 2));//Virgülden sonra kaç basamak geleceğini belirttik
            Console.WriteLine("Yuvarlama: {0}", Math.Round(Math.PI, 2));
            Console.WriteLine("aşağıya yuvarlama: {0}", Math.Floor(sayi));
            Console.WriteLine("yukarı yuvarlama: {0}", Math.Ceiling(sayi));
            Console.WriteLine("karesi: {0}", Math.Pow(sayi, 3));
            Console.WriteLine("karekökü: {0}", Math.Sqrt(sayi));
            Console.WriteLine("mutlak deger:{0}", Math.Abs(-12));


            Console.ReadKey();
        }
    }
}
