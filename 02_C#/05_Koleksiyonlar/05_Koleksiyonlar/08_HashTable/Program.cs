using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable'ın görevi çok sayıda elemanı key değerleri kullanılarak en hızlı şekilde eriştirmektir.
            //Bir key sadece bir kez kullanılabilir.

            Hashtable ht = new Hashtable();
            ht.Add(6, "Ankara");
            ht.Add("Test", "Deneme");
            ht.Add(10.2, "Sayi");
            ht.Add(true, false);
            //ht.Add(true, "Sayi"); // true key'i daha önce eklendiği için tekrar eklenemez! Bu satır çalışma zamanında hata alır!
            //6. key'ine sahip eleman var mı?
            Console.WriteLine(ht.ContainsKey(6) ? "Var": "Yok");

            //deneme value'suna sahip eleman var mı?
            Console.WriteLine(ht.ContainsKey("Deneme") ? "Var" : "Yok");

            //10.2 key'ine sahip eleman en hızlı bulunacak şekilde yerleştirilmiştir.
            object value = ht[10.2];
            Console.WriteLine(value);

            //Key'e göre silme 
            ht.Remove(true);

            //Koleksiyondaki elemanları ekrana yazdırmak istersek
            foreach (DictionaryEntry entry in ht)
                Console.WriteLine("{0} - {1}",entry.Key,entry.Value);

            //Sadece string'lerin saklanabileceği özelleştirilmiş bir koleksiyon
            StringCollection stringCollection = new StringCollection();
            stringCollection.Add("Deneme");
            

            Console.ReadKey();
        }
    }
}
