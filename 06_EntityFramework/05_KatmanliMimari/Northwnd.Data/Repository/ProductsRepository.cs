using Northwnd.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Data.Repository
{
    public class ProductsRepository : RepositoryBase<Products>, IProductsRepository
    {
        public ProductsRepository(NORTHWNDEntities context) : base(context)
        {
        }

        public ProductsRepository()
        {
        }
    }

    public interface IProductsRepository
    {
    }
}
