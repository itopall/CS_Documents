using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ReferansTipAdresleme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            int a = 10;
            int b = 20;

            //Value type'lar içerisinde sadece değer sakladıkları için b'nin değerinin sonradan değişmesi a'yı etkilemez!

            a = b;
            b = 30;
            Console.WriteLine("a: {0},b:{1}", a, b);

            //Referance Type
            Product p1 = new Product();
            p1.No = 10;

            Product p2 = new Product();
            p2.No = 20;



            //Reference type'lar içerisinde değer değil Heap'de tutulan değerin adresini sakladıkları için p1 = p2 tarzı bir eşitleme yapmak,bu iki tipin adresinin aynı olmasına sebep olur ve daha sonradan p2'de yapılan bir değişiklik p1'in değerinin de değişmesine sebep olur. Çünkü ikisi de artık aynı adrese bakıyor. 


            Console.ReadKey();
        }
    }

    class Product //Product:Ürün
    {
        public int No { get; set; }
    }
}
