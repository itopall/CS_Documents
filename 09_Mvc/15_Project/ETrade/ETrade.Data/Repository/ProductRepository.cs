using ETrade.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ETradeEntities context) : base(context)
        {
        }

        public ProductRepository()
        {
        }
    }

    interface IProductRepository
    {
    }
}
