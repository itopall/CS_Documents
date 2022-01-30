using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstveReadOnly
{
    class ReadOnlyTest
    {
        //ReadOnly ile tanımlanmış bir alan için constructor içerisnde değer ataması yapılabilir.

        public readonly int YalnızcaOkunanDeger = 30;
        public readonly int YalnızcaOkunanDeger2;
        public ReadOnlyTest()
        {
            //İlk başta atadığımız değeri constructor içerisinde değiştirebilirizç
            YalnızcaOkunanDeger = 40;
            //readonly olarak tanımlanmış alana constructor içerisinde ilk değer ataması yapabiliriz.
            YalnızcaOkunanDeger2 = 50;
        }
        public void DegerDegismez()
        {
            //non-static olarak tanımlanan metotlarda readonly olarak tanımlanan alanlara değer ataması ve değer değişmesi yapamayız.Aşağıdaki kod hatalıdır.
            //YalnızcaOkunanDeger = 60;
        }
    }
}
