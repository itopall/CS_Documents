using _01_Northwnd.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_UnitOfWorkveStaticRepository.Repository
{
    public class CategoriesRepository : RepositoryBase<Categories>, ICategoriesRepository
    {
        public CategoriesRepository(NORTHWNDEntities context) : base(context)
        {
        }
    }

    interface ICategoriesRepository
    {
    }
}
