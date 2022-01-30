using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_EventTabanlıProgramlama
{
    delegate void ProductHandler();
    class Product
    {
        public ProductHandler FiyatDegisti;

        public int Id { get; set; }
        public string Name { get; set; }

        double _price;
        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;

                if (FiyatDegisti != null)
                    FiyatDegisti.Invoke();

            }
        }
        public Product(int id,string name,double price)
        {
            Id = id;
            Name = name;
            Price = price;

        }
        
    }
}
