using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Interface_Ornek
{
    class ProductManager
    {
        public void Add(IProductDAL productDAL)
        {
            productDAL.ProductAdd();
        }

        public void Delete(IProductDAL productDAL)
        {
            productDAL.ProductDelete();
        }

        public void List(IProductDAL productDAL)
        {
            productDAL.ProductList();
        }

        public void Update(IProductDAL productDAL)
        {
            productDAL.ProductUpdate();
        }
    }
}
