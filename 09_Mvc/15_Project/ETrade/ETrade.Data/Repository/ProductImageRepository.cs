using ETrade.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Repository
{
    public class ProductImageRepository : RepositoryBase<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(ETradeEntities context) : base(context)
        {
        }

        public ProductImageRepository()
        {
        }
    }

    interface IProductImageRepository
    {
    }
}
