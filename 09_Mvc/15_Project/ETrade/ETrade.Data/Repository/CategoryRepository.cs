using ETrade.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(ETradeEntities context) : base(context)
        {
        }

        public CategoryRepository()
        {
        }
    }

    interface ICategoryRepository
    {
    }
}
