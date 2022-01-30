using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GenericMimari
{
    //T: Generic parametredir.
    //Nesne üretilirken tipi mutlaka söylenmek zorundadır. (int, string, Datetime vb olabilir)
    class Urun<T>
    {
        //T tipi class tasarımında her yerde kullanılabilir. Method, ctor, property dahildir. Sadece field olarak düşünmemek gerekir.
        public T Fiyat { get; set; }
        public T Kdv { get; set; }

        public Urun(T fiyat, T kdv)
        {
            Fiyat = fiyat;
            Kdv = kdv;

            //T newT; //T tipinde local bir değişken de tanımlanabilir.
        }
    }
}
