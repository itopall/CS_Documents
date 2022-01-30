using ETrade.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ETradeEntities context) : base(context)
        {
        }

        public EmployeeRepository()
        {
        }
    }

    interface IEmployeeRepository
    {
    }
}
