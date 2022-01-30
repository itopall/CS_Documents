using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedList sözlük tabanlı bir koleksiyon olduğundan elemanları key-value çiftleri şeklinde saklar.
            //Tüm sözlük tabanlı koleksiyonlar IDictionary İnterface'ini implement etmiştir.
            //Keyler unique olmak zorundadır yani aynı key iki kez eklenemez.
            //Sortedlist'in add methodu çağrıldığı anda, eklenen eleman, koleksiyondaki eygun sırada otomatik olarak yerleştirilir.
            //SortedList'in key'leri herhangi bibr tipp olabilir,ancak hangi tipten başladıysa o tiple devam edilmesi gerekir.

            //SortedList'in value'ları ise her daim istenen herhangi bir tipi alablir.

            //SortedList key değerlerine göre artan (Ascending) sıralama yapar.

            SortedList liste = new SortedList();
            liste.Add(34, "İstanbul");
            liste.Add(6, "Ankara");
            liste.Add(41, "Kocaeli");
            liste.Add(35, "İzmir");
            liste.Add(53, "Rize");
            //liste.Add(6, "Ankara"); //6 key'ine sahip bir eleman daha eklenemez
            liste.Add(44, true);//Value olarak farklı tipte değerler girebiliriz.

            //GetByIndex ile 0. index'teki elemanı ekrana yazdırdık.
            Console.WriteLine(liste.GetByIndex(0));

            //6 key'ine sahip elemanı getirir
            string str = (string)liste[6];
            Console.WriteLine(str);

            bool value = (bool)liste[44];
            Console.WriteLine(value);

            //key'i 41 olan eleman var mı?
            Console.WriteLine(liste.ContainsKey(41) ? "Var" : "Yok");

            // Value'su "istanbul" olan bir eleman var mı?
            Console.WriteLine(liste.ContainsValue("İstanbul") ? "Var" : "Yok");

            //Value'ya göre index değerini bulma
            Console.WriteLine("İstanbul'un index değeri: {0}",liste.IndexOfValue("İstanbul"));

            //Key'e göre index değerini bulma
            Console.WriteLine("53 key'nin index değeri: {0}", liste.IndexOfKey(53));

            //index'e göre key değerini bulma
            Console.WriteLine("1. index'inin key değeri: {0}", liste.GetKey(1));

            //Key listesini alma
            IList listeKey = liste.GetKeyList();

            //Value listesini alma
            IList listeValue = liste.GetValueList();

            //Key'e göre silme işlemi
            liste.Remove(44);

            //Index'e göre silme işlemi
            liste.RemoveAt(1);

            //Listedeki elemanları ekrana yazdırma
            foreach (DictionaryEntry entry in liste)
                Console.WriteLine("{0} - {1}",entry.Key,entry.Value);
            

            Console.ReadKey();
        }
    }
}
