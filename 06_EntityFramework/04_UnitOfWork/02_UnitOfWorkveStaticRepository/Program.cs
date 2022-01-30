using _01_Northwnd.Data;
using _02_UnitOfWorkveStaticRepository.Repository;
using _02_UnitOfWorkveStaticRepository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_UnitOfWorkveStaticRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            //CategoriesRepository categoriesRepository = new CategoriesRepository();

            UnitOfWorkStaticRepository uow = new UnitOfWorkStaticRepository();

            var list = uow.CategoriesRepository.GetAll().ToList();
            Console.WriteLine("Kategori Sayısı: {0}", list.Count);

            var productList = uow.ProductsRepository.GetAll().ToList();
            Console.WriteLine("Ürün Sayısı: {0}", productList.Count);

            var product = uow.ProductsRepository.GetById(10);
            Console.WriteLine("Ürün adı:" + product.ProductName);

            using (UnitOfWorkStaticRepository uow2 = new UnitOfWorkStaticRepository())
            {
                var categoryList = uow.CategoriesRepository.GetAll(p=> p.Picture != null).ToList();
                Console.WriteLine("Kategori Sayısı: {0}", list.Count);

                //Yeni bir Shipper ekleme
                //Shippers shipper = new Shippers();
                //shipper.CompanyName = "InsertTest111";
                //uow2.ShippersRepository.Add(shipper);
                //uow2.SaveChanges();
                //Console.WriteLine("Yeni oluşan ShipperId: {0}", shipper.ShipperID);

                //Update
                //var shipper = uow2.ShippersRepository.GetById(1033);
                //shipper.CompanyName = "UpdateTest111";
                //uow2.ShippersRepository.Update(shipper);
                //uow2.SaveChanges();
                //Console.WriteLine("Güncelleme işlemi başarılı...");

                var shipper = uow2.ShippersRepository.GetById(1033);
                uow2.ShippersRepository.Delete(shipper);
                uow2.SaveChanges();
                Console.WriteLine("Silme işlemi başarılı...");
            }


            Console.ReadKey();
        }
    }
}
