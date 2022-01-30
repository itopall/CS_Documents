using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Interface_Ornek
{
    class MSSqlServerProductDAL : IProductDAL
    {
        public void ProductAdd()
        {
            Console.WriteLine("Ürün ekleme işlemi MS SQL Server tarafından gerçekleşmiştir.");
        }

        public void ProductDelete()
        {
            Console.WriteLine("Ürün silme işlemi MS SQL Server tarafından gerçekleşmiştir.");

        }

        public void ProductList()
        {
            Console.WriteLine("Ürün listeleme işlemi MS SQL Server tarafından gerçekleşmiştir.");

        }

        public void ProductUpdate()
        {
            Console.WriteLine("Ürün güncelleme işlemi MS SQL Server tarafından gerçekleşmiştir.");

        }
    }
}
