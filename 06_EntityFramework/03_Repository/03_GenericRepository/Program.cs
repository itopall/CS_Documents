using _01_Northwnd.Data;
using _03_GenericRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            //Normal Entity Kullanımı
            //NORTHWNDEntities context = new NORTHWNDEntities();

            //var list = context.Products.ToList();
            //Console.WriteLine(list.Count);

            //Customers
            GenericRepository<Customers> genericRepositoryCustomers = new GenericRepository<Customers>();
            var list = genericRepositoryCustomers.GetAll().ToList();
            Console.WriteLine("Müşteri sayısı: " + list.Count);

            //Shippers
            GenericRepository<Shippers> genericRepositoryShippers = new GenericRepository<Shippers>();
            var list2 = genericRepositoryShippers.GetAll().ToList();
            Console.WriteLine("Kargocu sayısı: " + list2.Count);

            var shipper = genericRepositoryShippers.GetById(1);
            Console.WriteLine("1 Id'li Kargocu: " + shipper.CompanyName);

            //Employees
            GenericRepository<Employees> genericRepositoryEmployees = new GenericRepository<Employees>();
            var employee = genericRepositoryEmployees.GetById(5);
            Console.WriteLine("5 Id'li Çalışan: " + employee.FirstName + " "  + employee.LastName);

            var list3 = genericRepositoryEmployees.GetAll(p => p.Photo != null);
            foreach (var e in list3)
                Console.WriteLine(e.FirstName + " " + e.LastName);


            Console.ReadKey();
        }
    }
}
