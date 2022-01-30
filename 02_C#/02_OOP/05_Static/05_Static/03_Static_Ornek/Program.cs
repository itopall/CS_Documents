using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Static_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Product.kdvOrani = 0.18;

            Product p1 = new Product(1,"Elma",4.5);
            Product p2 = new Product(2, "Armut", 3.2);
            Product p3 = new Product(3, "Karpuz", 5.1);

            Console.WriteLine("ürün adı: {0}, Kdv Dahil Fiyatı: {1}", p1.ProductName, p1.kdvDahilFiyatiGetir());
            Console.WriteLine("ürün adı: {0}, Kdv Dahil Fiyatı: {1}", p2.ProductName, p2.kdvDahilFiyatiGetir());
            Console.WriteLine("ürün adı: {0}, Kdv Dahil Fiyatı: {1}", p3.ProductName, p3.kdvDahilFiyatiGetir());

            Product p4 = new Product();
            Console.WriteLine("nesne üretilme sayısı: {0}", Product.nesneUretilmeSayaci);
            Console.ReadKey();
        }
    }
}
