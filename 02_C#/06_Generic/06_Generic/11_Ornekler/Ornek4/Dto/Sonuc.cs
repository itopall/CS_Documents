using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Ornekler.Ornek4.Dto
{
    class Sonuc<T>
    {
        public bool BasariliMi { get; set; }
        public string Mesaj { get; set; }
        public T Data { get; set; }
    }
}
