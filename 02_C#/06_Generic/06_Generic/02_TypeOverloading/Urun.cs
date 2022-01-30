using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TypeOverloading
{
    class Urun<T>
    {
        public T Fiyat { get; set; }
        public T Kdv { get; set; }

        public Urun(T fiyat, T kdv)
        {
            Fiyat = fiyat;
            Kdv = kdv;
        }
    }

    class Urun<T, K>
    {
        public T Fiyat { get; set; }
        public K Kdv { get; set; }

        public Urun(T fiyat, K kdv)
        {
            Fiyat = fiyat;
            Kdv = kdv;
        }
    }
}
