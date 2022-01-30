using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Virtual
{
    class Havale:HesapIslemleri
    {
        //Virtual methodun default değeri zaten havale işleminin tutarını gösterdiği için  virtual metodu overrride etmeye gerek yoktur.
        //virtualMethodu()'u override ediyoruz. Base classtaki halini kullanıyoruz.
        public override int virtualMethod()
        {
            return base.virtualMethod();
        }
    }

}
