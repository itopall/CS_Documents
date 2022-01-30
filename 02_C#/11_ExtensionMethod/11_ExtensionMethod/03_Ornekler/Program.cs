using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ornek 1
            //int tipi için UsAl işlemi yapacak extension methodu yazınız

            int sayi = 10;
            Console.WriteLine( sayi.UstAl(2) );
            #endregion

            #region Ornek 2
            //String tipi içinboşluk  karakterini temizleme işlemi yapan extension methodu yazınız

            string yazi = "ilker topal";
            Console.WriteLine(yazi.RemoveSpace());
            #endregion

            Console.ReadKey();
        }
    }
    
}
