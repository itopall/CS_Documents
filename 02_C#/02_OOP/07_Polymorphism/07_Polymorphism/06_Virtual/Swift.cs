using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Virtual
{
    class Swift: HesapIslemleri
    {
        public override void ParaGonder(int miktar)
        {
            Console.WriteLine("{0} tutarında swift işlemi yapılmıştır.", miktar);
        }
        //parametresiz geriye değer döndüren virtual metottur.
        public virtual int virtualMethod()
        {
            return 1;
        }
        //virtualMethodu()'u override ediyoruz. Base classtaki halini kullanıyoruz.
    }
}
