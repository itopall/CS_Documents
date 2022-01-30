using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ConstructorOverloadOrnek
{
    class Customer
    {
        public int CustomerId { get; set; }
        public int CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }


        //parametresiz constructor 
        public Customer()
        {
            CustomerId = 1;
            CustomerNumber = 1234;
            Console.WriteLine("Parametresiz Constructor çalıştı." +Environment.NewLine + "Müşteri Id: "+CustomerId + Environment.NewLine + "customer number: " + CustomerNumber);
        }
        //SAdece CustomerId ve CustomerNumber parametrelerini alan constructor overload methodu
        public Customer(int Id, int number)
        {
            CustomerId = Id;
            CustomerNumber = number;
            Console.WriteLine("Customer Id: {0}\nCustomer Number: {1}", CustomerId, CustomerNumber);
        }
        //sadece FirstName ve LastName içeren parametreli constructor overload methodu
        public Customer(string isim,string soyisim)
        {
            FirstName = isim;
            LastName = soyisim;
            Console.WriteLine("İsim: {0}\nSoyisim: {1}", FirstName, LastName);
        }
        // büütn hepsinin bulunduğu parametreli constructor overload methodu
        public Customer(int id, int numara, string isim ,string soyisim,string ülke,string şehir)
        {
            CustomerId = id;
            CustomerNumber = numara;
            FirstName = isim;
            LastName = soyisim;
            Country = ülke;
            City = şehir;
            Console.WriteLine("Customer İd: {0}\ncustomer Numara: {1}\nİsim:{2}\nSoyİsim{3}\nÜlke:{4}\nŞehir:{5}", CustomerId, CustomerNumber, FirstName, LastName, Country, City);
        }
    }
}
