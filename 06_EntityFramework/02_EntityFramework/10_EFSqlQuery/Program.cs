using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EFSqlQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities context = new NORTHWNDEntities();

            //Entiy tipine göre (Products, Categories vs.) ya da tek bir tipde (string, int vs.) olmak üzere iki farklı şekilde SqlQuery çalıştırılabilir.

            #region Entity Tipine Göre
            //Sql Query ile Native sql sorgusu çalıştırma;
            var products = context.Products.SqlQuery("SELECT * FROM Products").ToList();
            Console.WriteLine("Ürün Sayısı: " + products.Count);

            //Parametrik sorgu çalıştırma
            var product = context.Products.SqlQuery("SELECT * FROM Products WHERE productId = @productId", new SqlParameter("@productId", 1)).FirstOrDefault();
            Console.WriteLine("1 Id'li ürün: " + product.ProductName);

            //HATA! Sütun isimleri entity nesneleriyle birebir aynı olmalıdır! Aşağıdaki kod çalışma zamanında hata alır!
            //var products2 = context.Products.SqlQuery("SELECT ProductId AS Id, ProductName AS Name FROM Products").ToList();

            //HATA! Sadece ilgili tabloya ait query yazılabilir. Aşağıdaki satır çalışma zamanında hata alır!
            //var employees = context.Products.SqlQuery("SELECT * FROM Employees").ToList();
            #endregion

            #region Farklı Bir Tipe Göre
            var names = context.Database.SqlQuery<string>("SELECT ProductName FROM Products").ToList();
            foreach (var name in names)
                Console.WriteLine(name);

            var unitPrice = context.Database.SqlQuery<decimal>("SELECT UnitPrice FROM Products").FirstOrDefault();
            Console.WriteLine(unitPrice);
            #endregion

            #region CRUD İşlemler
            ////INSERT
            //var result = context.Database.ExecuteSqlCommand("INSERT INTO Shippers(CompanyName) VALUES ('InsertTest2')");

            ////UPDATE
            //var result2 = context.Database.ExecuteSqlCommand("UPDATE Shippers SET CompanyName = 'UpdateTest2' WHERE CompanyName = 'InsertTest2'");

            ////DELETE 
            //var result3 = context.Database.ExecuteSqlCommand("DELETE FROM Shippers WHERE CompanyName = 'UpdateTest2'");
            #endregion

            #region Procedure Tetikleme
            var count = context.Database.SqlQuery<int>("dbo.ProductCount").FirstOrDefault();
            Console.WriteLine("ProductCount: " + count);

            var list = context.Orders.SqlQuery("dbo.GetOrderByCustomerId", "CACTU").ToList();
            Console.WriteLine("GetOrderByCustomerId: " + list.Count);
            #endregion

            Console.ReadKey();
        }
    }
}
