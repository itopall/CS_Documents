using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extension methodları yardımcı (helper) methodlar olarak düşünülebilir.
            //Extension method, static bir tipe yazılmış methodu, sanki nonstatic üyrymiş gibi çağırma imkanı verir. [TipdenUretilenDegiskenAdi.MethodAdi] notasyonu ile erişilmesine olanak sağlar.
            // Extension methodu kullanmak için yapılması gereken şey, static class içindeki static methodun ilk parametresinin basşına "this" keyword'ünü eklemektir.

            #region IntExtensions
            int sayi = 1000;

            //Normal static class ve static method kullanımı
            Console.WriteLine(IntExtensions.KarakterTamamla(sayi, 10));

            //Extension yöntemi kullanımı
            Console.WriteLine(sayi.KarakterTamamla(10));
            #endregion

            #region Stringextensions

            string karisikKelime = "deneme1234Test456";

            //Normal static kullanımı
            Console.WriteLine(StringExtensions.RemoveNumeric(karisikKelime));

            //Extensions kullanımı
            Console.WriteLine(karisikKelime.RemoveNumeric());
            #endregion


            



            Console.ReadKey();
        }
    }
}
