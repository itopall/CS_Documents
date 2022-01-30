using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_JoinIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities context = new NORTHWNDEntities();
            var list = context.Products.ToList();

            #region Join Query Yöntemi
            //var sonuc = (from p in context.Products
            //             join c in context.Categories on p.CategoryID equals c.CategoryID
            //             select new
            //             {
            //                 p.ProductName,
            //                 c.CategoryName
            //             });

            //foreach (var item in sonuc)
            //    Console.WriteLine($"{item.CategoryName} - {item.ProductName}");
            #endregion

            #region Join Method Yöntemi
            //var lambdaJoin = context.Products.Join(context.Categories,
            //                 p => p.CategoryID, c => c.CategoryID,
            //                 (p, c) => new { p.ProductName, c.CategoryName });

            //foreach (var item in lambdaJoin)
            //    Console.WriteLine($"{item.CategoryName} - {item.ProductName}");
            #endregion

            #region Join Query Yöntemi - Çoklu Join Kullanımı
            //var sonuc2 = (from p in context.Products
            //             join c in context.Categories on p.CategoryID equals c.CategoryID
            //             join s in context.Suppliers on p.SupplierID equals s.SupplierID
            //             select new
            //             {
            //                 p.ProductName,
            //                 c.CategoryName,
            //                 s.CompanyName
            //             });

            //foreach (var item in sonuc2)
            //    Console.WriteLine($"{item.CategoryName} - {item.ProductName} - {item.CompanyName}");
            #endregion

            #region Join Method Yöntemi - Çoklu Join Kullanımı
            var lambdaJoin2 = context.Products.Join(context.Categories,
                             p => p.CategoryID, c => c.CategoryID,
                             (p, c) => new { p.ProductName, c.CategoryName, p.SupplierID})
                             .Join(context.Suppliers,
                             p=>p.SupplierID, s=>s.SupplierID,
                             (p, s) => new { p.ProductName, p.CategoryName, s.CompanyName }).ToList();

            foreach (var item in lambdaJoin2)
                Console.WriteLine($"{item.CategoryName} - {item.ProductName} - {item.CompanyName}");
            #endregion

            Console.ReadKey();
        }
    }
}
