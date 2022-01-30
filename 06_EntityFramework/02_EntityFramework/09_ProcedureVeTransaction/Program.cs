using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ProcedureVeTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities context = new NORTHWNDEntities();

            #region Proc Tetikleme
            var count = context.ProductCount().FirstOrDefault();
            Console.WriteLine(count);

            //Parametre alan procedure tetikelme
            var list = context.GetOrderByCustomerId("CHOPS");
            foreach (var order in list)
            {
                Console.WriteLine($"{order.OrderID} || {order.OrderDate}");
            }
            #endregion

            #region Transaction
            using (DbContextTransaction transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Shippers shipper1 = new Shippers();
                    shipper1.CompanyName = "InsertTest3";
                    shipper1.Phone = "123123123";
                    var result = context.Shippers.Add(shipper1);
                    context.SaveChanges();

                    Suppliers supplier1 = new Suppliers();
                    supplier1.CompanyName = "InsertTest4";
                    supplier1.Phone = "543543543";
                    var result2 = context.Suppliers.Add(supplier1);
                    context.SaveChanges();

                    //Aşağıdaki satırda hata fırlatacağı için catch'e düşecek be Rollback edilerek yukarıda yapılan insert işlemleri geri alınacak.
                    //throw new Exception("Hata Test");

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
