using _01_Northwnd.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_UnitOfWorkveStaticRepository.Repository
{
    public class ProductsRepository : RepositoryBase<Products>, IProductsRepository
    {
        public ProductsRepository(NORTHWNDEntities context) : base(context)
        {
        }
    }

    interface IProductsRepository
    {
    }
}
