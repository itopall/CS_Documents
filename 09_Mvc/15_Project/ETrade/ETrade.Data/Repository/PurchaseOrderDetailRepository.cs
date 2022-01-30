using ETrade.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Repository
{
    public class PurchaseOrderDetailRepository : RepositoryBase<PurchaseOrderDetail>, IPurchaseOrderDetailRepository
    {
        public PurchaseOrderDetailRepository(ETradeEntities context) : base(context)
        {
        }

        public PurchaseOrderDetailRepository()
        {
        }
    }

    interface IPurchaseOrderDetailRepository
    {
    }
}
