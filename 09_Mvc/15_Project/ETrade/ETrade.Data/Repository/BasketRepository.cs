using ETrade.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Repository
{
    public class BasketRepository : RepositoryBase<Basket>, IBasketRepository
    {
        public BasketRepository(ETradeEntities context) : base(context)
        {
        }

        public BasketRepository()
        {
        }
    }

    interface IBasketRepository
    {
    }
}
