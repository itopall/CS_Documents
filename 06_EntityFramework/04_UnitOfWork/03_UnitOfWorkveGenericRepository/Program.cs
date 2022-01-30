using _01_Northwnd.Data;
using _03_UnitOfWorkveGenericRepository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_UnitOfWorkveGenericRepository
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //UnitOfWork üzerinden generic Repository'leri çağırma
            UnitOfWorkGenericRepository uow = new UnitOfWorkGenericRepository();
            var customerRepository = uow.GetRepository<Customers>();
            var productRepository = uow.GetRepository<Products>();

            var pList = productRepository.GetAll().ToList();
            Console.WriteLine("Ürün sayısı: {0}", pList.Count);

            var cList = customerRepository.GetAll().ToList();
            Console.WriteLine("Müşteri sayısı: {0}", cList.Count);

            using (UnitOfWorkGenericRepository uow2 = new UnitOfWorkGenericRepository())
            {
                var employeeRepository = uow.GetRepository<Employees>();

                var eList = employeeRepository.GetAll().ToList();
                foreach (var calisan in eList)
                    Console.WriteLine(calisan.FirstName);
            }

            Console.ReadKey();
        }
    }
}
