using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList'in ctor'una parametre olarak ICollection tipinde bir parametre gönderebiliyoruz.Gönderilen nesne ArrayList'in içerisine tek seferde eklenir.
            ArrayList liste = new ArrayList(new int[] { 5, 46, 7, 6, 1, 32, 17 });
            liste.Add(true);
            liste.Add(false);
            liste.Add(true);

            //ilk ve son eleman
            Console.WriteLine("ilk eleman: {0}",liste[0]);
            Console.WriteLine("son eleman: {0}",liste[liste.Count - 1]);

            //Tüm elemanları ekrana yazdırma
            for (int i = 0; i < liste.Count; i++)
                Console.WriteLine(liste[i]);

            //Int üzerinden dönüldüğü için listenin içerisindeki int'den farklı tipler de olduğundan dolayı aşağıdaki foreach iterasyonu hata alır.. 
            //foreach (int item in liste)
            //    Console.WriteLine(item);

            //object üzerinden dönüldüğü için hata olmadan bütün elemanları ekrana yazar
            foreach (object item in liste)
                Console.WriteLine(item);
            #region listedeki tiplerine göre ayrı dizilere bölme
            bool[] durumlar;
            int[] sayilar;

            ArrayList sayilarArrayList = new ArrayList();
            ArrayList durumlarArrayList = new ArrayList();
            foreach (object item in liste)
            {
                if (item is Int32)
                    sayilarArrayList.Add(item);
                else if (item is bool)
                    durumlarArrayList.Add(item);
                
            }
            sayilar = (int[])sayilarArrayList.ToArray(typeof(Int32));
            durumlar = (bool[])durumlarArrayList.ToArray(typeof(bool));

            //Capacity'yi count'a eşitleyerek boş kapasitenin yok edilmesini sağlar.
            liste.TrimToSize();
            Console.WriteLine(liste.Count);
            Console.WriteLine(liste.Capacity);
            #endregion



            Console.ReadKey();
        }
    }
}
