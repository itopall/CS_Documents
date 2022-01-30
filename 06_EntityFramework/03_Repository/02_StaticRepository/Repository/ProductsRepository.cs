using _01_Northwnd.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StaticRepository.Repository
{
    public class ProductsRepository : RepositoryBase<Products>, IProductsRepository
    {
        public ProductsRepository()
        {
        }

        //Base'de olmayan sadece Products'a özel olan db işlemi methodları burada yazılabilir.
        //public IQueryable<Products> GetProductsReport()
        //{
        //    return null;
        //}
    }

    interface IProductsRepository
    {
        //IQueryable<Products> GetProductsReport();
    }
}
