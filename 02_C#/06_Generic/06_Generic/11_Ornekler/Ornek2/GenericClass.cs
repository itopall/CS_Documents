using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Ornekler.Ornek2
{
    class GenericClass<T,K>
    {
        public T GenericProperty1 { get; set; }
        public K GenericProperty2 { get; set; }

        public GenericClass(T genericProperty1, K genericProperty2)
        {
            GenericProperty1 = genericProperty1;
            GenericProperty2 = genericProperty2;
        }

        public void Reset()
        {
            //default T; tipin default değerini döndürür.
            //T int olursa 0, string olursa null gibi 
            GenericProperty1 = default(T);
            GenericProperty2 = default(K);
        }
    }
}
