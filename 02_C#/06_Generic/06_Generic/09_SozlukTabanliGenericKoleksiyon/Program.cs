using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SozlukTabanliGenericKoleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sözlük Tabanlı Koleksiyon Hatırlatma
            SortedList list = new SortedList();
            list.Add(34, "İstanbul");
            list.Add(6, "Ankara");

            //Aşağıdaki gibi farklı bir tip eklemeye çalışılırsa, çalışma zamanında hata verir.
            //Tip güvenliği sorunu!
            //list.Add("test", "Ankara");

            //Performans sorunu!
            string eleman = (string)list[6];
            Console.WriteLine(list[34]);

            foreach (DictionaryEntry de in list)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            #endregion

            #region Generic SortedList
            SortedList<int, string> sehirler = new SortedList<int, string>();
            sehirler.Add(34, "İstanbul");
            sehirler.Add(6, "Ankara");
            //sehirler.Add("test", "Bursa"); //Tip güvenliği sağlandı!

            string sehir = sehirler[34]; //Performans sorunu aşıldı! Cast edilmedi.
            Console.WriteLine(sehirler[6]);

            foreach (KeyValuePair<int, string> kvp in sehirler)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            #endregion

            #region Dictionary
            Dictionary<int, string> sehirler2 = new Dictionary<int, string>();
            sehirler2.Add(34, "İstanbul");
            sehirler2.Add(6, "Ankara");
            //sehirler2.Add("test", "Bursa"); //Tip güvenliği sağlandı!

            string sehir2 = sehirler2[34]; //Performans sorunu aşıldı! Cast edilmedi.
            Console.WriteLine(sehirler2[6]);

            foreach (KeyValuePair<int, string> kvp in sehirler2)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            #endregion

            Console.ReadKey();
        }
    }
}
