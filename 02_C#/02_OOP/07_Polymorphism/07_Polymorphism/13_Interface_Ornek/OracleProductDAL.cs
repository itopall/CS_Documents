using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Interface_Ornek
{
    class OracleProductDAL : IProductDAL
    {
        public void ProductAdd()
        {
            Console.WriteLine("Ürün ekleme işlemi Oracle tarafından gerçekleşmiştir.");
        }

        public void ProductDelete()
        {
            Console.WriteLine("Ürün silme işlemi Oracle tarafından gerçekleşmiştir.");
        }

        public void ProductList()
        {
            Console.WriteLine("Ürün listeleme işlemi Oracle tarafından gerçekleşmiştir.");
        }

        public void ProductUpdate()
        {
            Console.WriteLine("Ürün güncelleme işlemi Oracle tarafından gerçekleşmiştir.");
        }
    }
}
