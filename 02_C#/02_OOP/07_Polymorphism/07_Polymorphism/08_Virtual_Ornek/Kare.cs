using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Virtual_Ornek
{
    class Kare:Hesaplamalar
    {
        public int KenarUzunlugu { get; set; }
        
        public override void alan()
        {
            Console.Write("alan için kenar uzunluğu giriniz: ");
            KenarUzunlugu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("karenin alanı: {0}", KenarUzunlugu * KenarUzunlugu);
        }
        public override void Cevre()
        {
            Console.Write("Çevre için kenar uzunluğu giriniz: ");
            KenarUzunlugu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("karenin çevresi: {0}", 4 * KenarUzunlugu);
        }
    }
}
