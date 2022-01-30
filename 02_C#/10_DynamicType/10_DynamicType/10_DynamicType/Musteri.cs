using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DynamicType
{
    class Musteri
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }

        public void Gorunteleme()
        {
            Console.WriteLine("Adı: {0}, Soyadı: {1}, Doğum Tarihi: {2}",Adi,Soyadi,DogumTarihi);
        }
    }
}
