using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_EventTabanlıProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1, "Monitör", 1200);
            product.FiyatDegisti = OnPriceChanged;

            product.Price = 1300;


            Console.ReadKey();
        }
        static void OnPriceChanged()
        {
            Console.WriteLine("Ürün fiyatı değişti...");
        }
        static void OnpriceChanged_SendMail()
        {
            Console.WriteLine("Sayın ürün yetkilisi, ürün fiyatı değişti...");
        }
    }
}
