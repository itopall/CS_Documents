using Northwnd.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Data.Repository
{
    public class CategoriesRepository : RepositoryBase<Categories>, ICategoriesRepository
    {
        public CategoriesRepository(NORTHWNDEntities context) : base(context)
        {
        }

        public CategoriesRepository()
        {
        }
    }

    interface ICategoriesRepository
    {
    }
}
