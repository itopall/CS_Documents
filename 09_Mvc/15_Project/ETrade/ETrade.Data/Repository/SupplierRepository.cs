using ETrade.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Repository
{
    public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        public SupplierRepository(ETradeEntities context) : base(context)
        {
        }

        public SupplierRepository()
        {
        }
    }

    interface ISupplierRepository
    {
    }
}
