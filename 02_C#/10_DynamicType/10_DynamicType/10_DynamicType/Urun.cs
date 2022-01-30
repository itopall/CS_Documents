using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DynamicType
{
    class Urun
    {
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Kategorisi { get; set; }

        public void Gorunteleme()
        {
            Console.WriteLine("Adı: {0}, Soyadı: {1}, Doğum Tarihi: {2}", Adi, Fiyati, Kategorisi);
        }
    }
}
