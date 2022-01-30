using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GenericMimari
{
    class TestSinifi<T>
    {
        public int NonGenericField; //NonGenericField'ın tipi tasarım zamanında belli olmuştur
        public T GenericField; //GenericField'ın tipi tasarım zamanında belli DEĞİLDİR! Nesne üretilirken belirlenecektir.
    }
}
