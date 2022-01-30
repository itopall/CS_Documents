using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OperatorleriAsiriYuklemek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Log4Net, NLog gibi hazır log kütüphaneleri çok pratik bir şekilde kullanılabilir.
            LogItem item = new LogItem(1, "Kayıt oluşturulurken hata oluştu!", DateTime.Now, LogItemPriority.High);

            #region Implicit ve Explicit Örneği
            string mesaj = item;
            Console.WriteLine(mesaj);

            //Explicit atama örneği (CAST)
            TimeSpan sure = (TimeSpan)item;
            int idDegeri = (int)item;
            #endregion

            #region ++, --, +, - Operatörleri
            item++;
            item++;
            item++;
            item--;
            item--;
            item += 5; //item = item + 5; Aynı anlama gelir
            item -= 2; //item = item - 2; Aynı anlama gelir
            #endregion


            Console.ReadKey();
        }
    }
}
