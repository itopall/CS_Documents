using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Id = 1;
            p.Name = "Klavye";
            p.Price = 100;
            Console.WriteLine(Product.Kdv);

            Email.SendEmail("ali@gmail.com", "veli@gmail.com", "Merhaba nasılsın");

            //Const ve readonly
            //p.NesneyeAitSabitSayi = 30;
            Console.WriteLine(p.NesneyeAitSabitSayi);

            //Product.PiSayisi = 4;
            Console.WriteLine(Product.PiSayisi);

            Console.ReadKey();
        }
    }

    //Nonstatic bir tip içerisine static üye eklenebilir. (Kdv)
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public static double Kdv { get; set; } = 0.18;

        //Const ve readonly kullanımı
        public const double PiSayisi = 3.14;
        public readonly int NesneyeAitSabitSayi = 10;

        public Product()
        {
            //PiSayisi = 1;
            NesneyeAitSabitSayi = 20;
        }
    }

    static class Email
    {
        public static bool SendEmail(string from, string to, string body)
        {
            try
            {
                //Email gönderme adımları uygulanabilir.

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
