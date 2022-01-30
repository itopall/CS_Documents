using Northwnd.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Data.Repository
{
    public class EmployeesRepository : RepositoryBase<Employees>, IEmployeesRepository
    {
        public EmployeesRepository(NORTHWNDEntities context) : base(context)
        {
        }

        public EmployeesRepository()
        {
        }
    }

    interface IEmployeesRepository
    {
    }
}
