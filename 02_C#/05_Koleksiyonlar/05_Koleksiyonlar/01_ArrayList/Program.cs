using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Kullanımı
            //Liste tabanlı olarak elemanları ekleme sırasıyla bir arada tutan ve bu elemanlara kolay bir şekilde erişmemizi sağlayan koleksiyon tipidir
            ArrayList liste = new ArrayList();

            //Add methodu ile listeye object tipinden nesneler ekliyoruz
            liste.Add(10);
            liste.Add(5);
            liste.Add(DateTime.Now);
            liste.Add(DateTime.Now);
            liste.Add(DateTime.Now);//Kapasite aşıldığı için resize işlemi otomatik olarak yapılır
            liste.Add(DateTime.Now);
            liste.Add(DateTime.Now);
            liste.Add(DateTime.Now);
            liste.Add(DateTime.Now);

            //Capacity property'si koleksiyonun kendi içinde elemanları bir arada tutmak için kullanmış olduğu dizinin length'ini getirir.Dizinin count'u length'ine eşit olduğunda bir sonraki elemna işleminde dizinin resize işlemi yaparak kapasitenin 2 katına çıkarılmasını sağlar.

            //Kapasitenin 2'ye katlanarak artması resize sayısını azaltarak performansın artmasını sağlayacaktır.

            //Resize işlemi: Bir dizinin kapasitesinin artması için dizinin yeniden üretilip eski elemanlarının diziye kopyalanması gerekir.Bu işlem performansı olumsuz etkilyeceğinden, kapasite arttırması ikiye katlanarak yapılır.

            Console.WriteLine("Count: " + liste.Count);
            Console.WriteLine("Capacity: " + liste.Capacity);
            #endregion

            #region AddRange kullanımı
            //Bir methodu parametre olarak bir interface istiyorsa,methodun istediği o interface'i implement etmiş bir nesnedir.
            //Örneğin ArrayList tipi,ICollection'ı implement ettiği için AddRange methoduna parametre olarak bir ArrayList nesnesi gönderilebilr.
            ArrayList liste2 = new ArrayList();
            liste2.Add("Test");
            liste2.Add("Deneme");

            //liste2 ICollection'ı implement een bir tipi ait nesne (ArrayList Tipinde) olduğu için AddRange methoduna parametre olarak gönderilir.
            liste.AddRange(liste2);
            liste.AddRange(liste2);

            //Tüm diziler Array tipinden kalıtılmıştır.Array tipi incelendiğinde IColection interfaci'ini implement ettiği görülür.Dolayısıyla object dizisi, ICollection interface'ine uyan bir nesnedir ve AddRange methoduna parametre olarak gönderilir.
            liste.AddRange(new object[] { 5, true, DateTime.Now });

            //Aynı şekilde ToCharArray ile de AddRange methoduna parametre gönderilebilir.
            liste.AddRange("deneme".ToCharArray());

            Console.WriteLine("Count: " + liste.Count);
            Console.WriteLine("Capasity: " + liste.Capacity);
            #endregion

            #region Remove
            //Listeden 5'in çıkarılmasını sağlar.Ancak listede birden fazla 5 varsa sadece listedeki ilk sırada bulunan 5'İ siler.
            //Remove işlemleri sonrasında kapasite azaltılmaz!
            liste.Remove(5);

            //0 index'li eleman 10 olduğu için listeden 10'u siler.
            liste.RemoveAt(0);

            //0 index'li elemandan itibaren 7 eleman siler(Tarih değerleri)
            liste.RemoveRange(0,7);

            //Listeden bütün 5'leri method ile siliyoruz.
            Sil(liste, 5);
            #endregion

            #region Contains
            //Aranan değerin listenin içerisinde olup olmadığını kontrol eder.
            Console.WriteLine(liste.Contains("Test") ? "Var" : "Yok");
            #endregion

            #region Insert

            //1 index'li elemanı İlker olarak set eder sonraki elemanlar birer index ötelenir.
            liste.Insert(1, "İlker");

            //1 index'li elemandan itibaren parametre olarak gönderilen dizideki elemanları ekler sonraki elemanlar birer index ötelenir.
            liste.InsertRange(1, new object[] { 100, 200, 300, "test" });
            #endregion

            #region Reverse
            //Elemanları tersine çevirir.
            liste.Reverse();
            #endregion

            #region ToArray
            object[] objects = liste.ToArray();

            //ArrayList'in içerisindeki her eleman aynı tipten ise, o tipin dizisini elde etmek için ToArray'in overload edilmiş versiyonu kullanılabilir.
            ArrayList sayilarArrayList = new ArrayList();
            sayilarArrayList.Add(10);
            sayilarArrayList.Add(20);

            int[] sayilar = (int[])sayilarArrayList.ToArray(typeof(Int32));
            #endregion



            Console.ReadKey();
        }

        private static void Sil(ArrayList liste, int silinecekSayi)
        {
            //while döngüsü
            while (liste.Contains(silinecekSayi))
            {
                liste.Remove(silinecekSayi);
            }

            //Recursive methodu yöntemi
            //liste.Remove(silinecekSayi);
            //if (liste.Contains(silinecekSayi))
            //    Sil(liste, silinecekSayi);
        }
    }
}
