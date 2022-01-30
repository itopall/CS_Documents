using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Inheritance_Ornekler
{
    class manav
    {
        public int Id;
        public string ad;
        public double fiyat;
        public double kg;

    }
    class Meyveler : manav
    {
        public string meyvesuyu;
        public void MeyveSuyunuYazdır()
        {
            Console.WriteLine("yapılan meyve suyu: {0}", meyvesuyu);
        }
    }
    class Sebzeler : manav
    {
        public string yapılanyemek;
        public void YemegiYazdir()
        {
            Console.WriteLine("yapılan yemek:{0}", yapılanyemek);
        }
    }
}
