using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Static_Ornek
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        //static property
        public static double kdvOrani { get; set; }
        public static int nesneUretilmeSayaci { get; set; }

        public Product(int id, string name, double _price):this()
        {
            ProductId = id;
            ProductName = name;
            Price = _price;
        }
        //Parametresiz constructor
        public Product()
        {
            //nesneüretilemesayacını birer arattıralım
            nesneUretilmeSayaci++;
        }
        //nonstatic geriye değer döndüren metot
        public double kdvDahilFiyatiGetir()
        {
            return Price + Price * Product.kdvOrani;
        }
    }
}
