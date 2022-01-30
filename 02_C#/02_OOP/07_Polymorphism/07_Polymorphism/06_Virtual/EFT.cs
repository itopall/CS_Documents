using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Virtual
{
    class EFT : HesapIslemleri
    {
        //hesap işlemleri classındaki oluşturulmuş virtual metoda Eft classı içerisinde polimorfik bir yapı kazandırmış olduk.
        public override void ParaGonder(int miktar)
        {
            Console.WriteLine("{0} tutarında Eft yapıldı.", miktar);
        }
        //virtualMethodu()'u override ediyoruz. Base classtaki halini kullanıyoruz.
    }
}
