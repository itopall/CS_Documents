using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Interface_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = new ProductManager();
            //productManager.Add(new MysqlDAL());

            //ProductManager productManager2 = new ProductManager();
            //productManager2.Delete(new MysqlDAL());

            //ProductManager productManager3 = new ProductManager();
            //productManager3.Update(new MysqlDAL());

            //ProductManager productManager4 = new ProductManager();
            //productManager4.List(new MysqlDAL());

            //Tüm veri tabanları için tüm CRUD işlemlerini gerçekleştirelim.
            IProductDAL[] productDALs = new IProductDAL[3]
            {
                new OracleProductDAL(),
                new MysqlDAL(),
                new MSSqlServerProductDAL()
            };
            //SAdece tek bir veri tabanı için tüm CRUD işlemleri
            //IProductDAL[] productDALs = new IProductDAL[1]
            //{
            //    new OracleProductDAL()
            //};
            foreach(var item in productDALs)
            {
                item.ProductAdd();
                item.ProductDelete();
                item.ProductList();
                item.ProductUpdate();
            }


            Console.ReadKey();
        }
    }
}
