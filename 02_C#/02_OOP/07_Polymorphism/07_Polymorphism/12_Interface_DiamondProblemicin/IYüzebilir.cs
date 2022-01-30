using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interface_DiamondProblemicin
{
    interface IYüzebilir
    {
        //Interfacelerde erişim belirleyicileri public olmalıdır.
        //Interface'in amacı farklı tipler arasında standart sağlamak için oluşturduğumuz yapılardır.Bu yüzden farklı tiplerden kolay bir şekilde erişim sağlaması için defaultu public olarak tanımlanmıştır.

        void Yuz();//içi boş bir metoddur.
    }
}
