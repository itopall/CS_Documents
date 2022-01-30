using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstveReadOnly
{
    class ConstTest
    {
        //Const ile bitirilmiş alanlar otomatik olarak static alanlar haline gelir.
        //Const = sabitler
        //Pi sayısı ^.14 const olarak örnek verilebilir. E = 2.7...sayısı const olarak örnek verilebilir.
        //const ile tanımlanan alanlara class ismi ile ulaşabiliri.

        public const double PiSayisi = 3.14;
        public const double E = 2.7;

        public const double sayi1 = 5.2;

        //Console.Readline() metodu ile kullanıcının girdiği değeri okuyup, const alanına atama yapamayız.
        //Aşayığadaki kullanım hatalı bir kullanımdır.
        //public const int sayi2 = Convert.ToInt32(Console.ReadLine());

        public const double toplam = sayi1 + PiSayisi;

        public ConstTest()
        {
            //const ile tanımlanan alana constructor içerisinde farklı bir değer ataması yapamayız.
            //Sadece const alan nerede tanımlanırsa orada değer ataması yapılır. Sonrasında hiçbir yerde değişiklik yapılamaz.
            //Aşağıdaki kod yazımı yanlıştı.
            //PiSayisi = 3.14;
            //E = 2.72;
            //toplam = 2.4; 
        }
    }
}
