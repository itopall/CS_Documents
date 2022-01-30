using ETrade.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Repository
{
    public class EmployeeTypeRepository : RepositoryBase<EmployeeType>, IEmployeeTypeRepository
    {
        public EmployeeTypeRepository(ETradeEntities context) : base(context)
        {
        }

        public EmployeeTypeRepository()
        {
        }
    }

    interface IEmployeeTypeRepository
    {
    }
}
