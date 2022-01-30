using _01_Northwnd.Data;
using _02_StaticRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StaticRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            //Normal Entity Kullanımı
            //NORTHWNDEntities context = new NORTHWNDEntities();

            //var list = context.Products.ToList();
            //Console.WriteLine(list.Count);

            #region Product Repository Kullanımı
            ProductsRepository productRepository = new ProductsRepository();

            //Static Repository ile ürün listesini alma
            var list = productRepository.GetAll().ToList();
            Console.WriteLine(list.Count);

            //Filtreli ürün listesi alma
            var list2 = productRepository.GetAll(p=>p.UnitPrice > 50).ToList();
            Console.WriteLine(list2.Count);

            //Id'ye göre ürün çekme
            var product = productRepository.GetById(87);
            Console.WriteLine(product.ProductName);

            ////Insert
            //productRepository.Add(new Products());

            ////Update
            //productRepository.Update(product);

            ////Delete
            //productRepository.Delete(product);
            #endregion

            #region Categories Repository Kullanımı
            CategoriesRepository categoriesRepository = new CategoriesRepository();

            var categoryList = categoriesRepository.GetAll().ToList();
            Console.WriteLine(categoryList.Count);
            #endregion


            Console.ReadKey();
        }
    }
}
