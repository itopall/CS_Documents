using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Generic
{
    class Product<T>
    {
        public T Fiyat { get; set; }
        public T Kdv { get; set; }

        public Product(T fiyat, T kdv)
        {
            Fiyat = fiyat;
            Kdv = kdv;
        }
    }

    class Product<T, K>
    {
        public T Fiyat { get; set; }
        public K Kdv { get; set; }

        public Product(T fiyat, K kdv)
        {
            Fiyat = fiyat;
            Kdv = kdv;
        }

        public void OrnekMethod<L>(L deger)
        {
        }
    }
}
