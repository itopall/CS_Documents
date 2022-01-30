using ETrade.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Repository
{
    public class BasketDetailRepository : RepositoryBase<BasketDetail>, IBasketDetailRepository
    {
        public BasketDetailRepository(ETradeEntities context) : base(context)
        {
        }

        public BasketDetailRepository()
        {
        }
    }

    interface IBasketDetailRepository
    {
    }
}
