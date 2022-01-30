using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Virtual_Ornek
{
    class Dikdörtgen:Hesaplamalar
    {
        public int kisaKenar { get; set; }
        public int uzunKenar { get; set; }
        public override void alan()
        {
            Console.WriteLine("kısa kenar uzunluğu giriniz.");
            kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("uzun kenar uzunluğu giriniz.");
            uzunKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin alanı:{0}", kisaKenar * uzunKenar);
            Console.WriteLine("Dikdörtgenin çevresi: {0}", (2 * kisaKenar + 2 * uzunKenar));
        }
    }
}
