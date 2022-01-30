using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_GenericKoleksiyon
{
    class KendiListem<T>
    {
        T[] _items;

        const int DefaultCapacity = 4;

        public KendiListem()
        {
            _items = new T[DefaultCapacity];
        }

        public void Add(T value)
        {
            //Ekleme işlemleri yapılır.
        }

        public void Remove(T value)
        {
            //Silme işlemleri yapılır.
        }
    }
}
