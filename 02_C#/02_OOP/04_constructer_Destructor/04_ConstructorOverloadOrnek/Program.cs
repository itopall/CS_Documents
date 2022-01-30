using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ConstructorOverloadOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //customer class'ı yapalım.class içerisindeki propertyler;CustomerId CustomerNumber, FirstName, LastName, Country, City.Parametresiz constructor oluşturalım, customerId ve CustomerNumber parametrelerine sahip overload constructor oluşturalım.FirstName ve LastName parametrelerine sahip overload constructor oluşturalım.CustomerId CustomerNumber,FirstName,LastName ,Country ve city parametrelerine sahip üçüncğ bir overload constructor oluşturalım.

            Customer c = new Customer();
            Customer c1 = new Customer(2,546);
            Customer c2 = new Customer("ilker", "topal");
            
            Customer c3 = new Customer(3, 413, "ilker", "topal", "Türkiye", "Kocaeli");

            
            Console.ReadKey();
        }
    }
}
