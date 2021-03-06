using ETrade.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Repository
{
    public class PurchaseOrderRepository : RepositoryBase<PurchaseOrder>, IPurchaseOrderRepository
    {
        public PurchaseOrderRepository(ETradeEntities context) : base(context)
        {
        }

        public PurchaseOrderRepository()
        {
        }
    }

    interface IPurchaseOrderRepository
    {
    }
}
