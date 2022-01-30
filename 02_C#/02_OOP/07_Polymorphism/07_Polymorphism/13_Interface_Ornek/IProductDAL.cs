using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Interface_Ornek
{
    interface IProductDAL
    {
        //Bu interface içerisinde ürün ekleme,silme,güncelleme ve listeleme metotları tanımlayacağız.

        //CRUD işlemleri
        //Create(ürün ekleme)
        //Read(ürün listeleme)
        //Update(ürün güncelleme)
        //Delete(ürün silme)

        void ProductAdd();

        void ProductDelete();

        void ProductUpdate();

        void ProductList();
    }
}
