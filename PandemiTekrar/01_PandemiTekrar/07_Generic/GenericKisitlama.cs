using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Generic
{
    class Personel
    {
    }

    class GeneralManager : Personel
    {
    }

    class SadecePersonel<T> where T : Personel
    {
    }

    class SadeceGeneralManager<T> where T : GeneralManager
    {
    }

    class Orneklenebilenler<T> where T : new()
    {
        void Test()
        {
            T obj = new T();
        }
    }

    class InterfaceZorunlu<T> where T : IEnumerable, IComparable
    {
    }

    class BirdenFazlaParametreAlan<T, K, L>
        where T : class
        where K : struct, IEnumerable
        where L : IComparable
    {
    }
}
