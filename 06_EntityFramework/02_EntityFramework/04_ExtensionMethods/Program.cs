using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dapper bir mikro ORM yapısıdır. Performans olarak çok hızlıdır. İncelemenizi tavsiye ederim.

            NORTHWNDEntities context = new NORTHWNDEntities();
            var list = context.Products.ToList();

            #region Where Methodu
            //Iterasyon yapılan nesneler içinde filtreleme yapılarak belli nesnelerin elde edilmesini sağlar.

            //Not: Where ile filtrelediğimiz sorgu üstünden tekrar tekrar where yapılarak bir filtreleme işlemi daha gerçekleştirebiliriz.
            IEnumerable<Products> pahaliUrunler = list.Where(p => p.UnitPrice > 40);
            IEnumerable<Products> pahaliCategoryBirOlanlar = pahaliUrunler.Where(p=> p.CategoryID == 1);

            //Yukarıdaki 2 sorgunun yaptığı işi tek seferde yapar. (Where içerisinde birden fazla kriter aynı anda kullanılabilir)
            IEnumerable<Products> pahaliUrunler2 = list.Where(p => p.UnitPrice > 40 && p.CategoryID == 1);
            IEnumerable<Products> ucuzUrunler = list.Where(p => p.UnitPrice > 0 && p.UnitPrice < 10 && p.CategoryID == 1);

            //Not: Where methodunun aşırı yüklenmiş şeklinde, methoda gelen ilk parametre (u) gelen üründür ikinci parametre (i) ise gelen ürünün index numarasıdır.
            IEnumerable<Products> sorgu1 = list.Where((u, i) => u.UnitPrice > 40 && i < 60);
            Console.WriteLine("Sorgu: " + sorgu1.Count());
            #endregion

            #region Select Methodu
            //Iterasyon yapılan nesnelere karşılık başka bir nesne elde etmek için kullanılır.
            //HEr ürünün sadece Id değerini liste olarak aldık
            IEnumerable<int> select1 = list.Select(p => p.ProductID);
            foreach (var id in select1)
                Console.WriteLine(id);

            //Her bir ürünün fiyatına 10% kdv ekleyip liste olarak aldık
            IEnumerable<decimal?> select2 = list.Select(p => p.UnitPrice * Convert.ToDecimal(1.1));
            foreach (var unitPrice in select2)
                Console.WriteLine(unitPrice);

            //Her bir ürünün yerine 10000 değerinin gelmesini sağladık.
            IEnumerable<int> select3 = list.Select(p => 10000);
            foreach (var deger in select3)
                Console.WriteLine(deger);
            #endregion

            #region OrderBy ve OrderByDesending Methodları
            //UnitPrice'a göre artan sıralama yaparak bütün fiyatları ekrana yazdıralım
            IOrderedEnumerable<Products> siraliUrunler = list.OrderBy(p => p.UnitPrice);
            foreach (var p in siraliUrunler)
                Console.WriteLine(p.UnitPrice);

            //UnitPrice'a göre azalan sıralama
            foreach (var p in list.OrderByDescending(p=> p.UnitPrice))
                Console.WriteLine(p.UnitPrice);

            //Ürünlerin adlarına göre sıralayıp sadece adlarında gezerek ekrana yazdıralım.
            foreach (var p in list.OrderBy(p => p.ProductName).Select(p=> p.ProductName))
                Console.WriteLine(p);

            Console.WriteLine("------------------------------------------------");

            //2 Id'li kategoriye ait ürünleri UnitPrice'ına göre azalan sıralayıp adlarını ekrana yazdıralım.
            foreach (var p in list.Where(p=> p.CategoryID == 2).OrderByDescending(p=>p.UnitPrice))
                Console.WriteLine(p.ProductName);

            //2 Id'li kategoriye ait olan ya da 3 Id'li kategoriye ait olan ve fiyatı 50'nin üzerinde olan ürünleri name'ine göre sıralayıp ekrana yazdıralım.
            var result = list.Where(p => p.CategoryID == 2 || p.CategoryID == 3 && p.UnitPrice > 50).OrderBy(p => p.ProductName);

            foreach (Products p in result)
                Console.WriteLine($"{p.ProductName} - {p.CategoryID} - {p.UnitPrice}");
            #endregion

            #region Distinct
            //Gelen sonuç kümesi içindeki tekrarlı elemanları (aşağıdaki örnekte categoryId'ler) tekilleştirmek için kullanılır.
            foreach (var categoryId in list.Select(p => p.CategoryID).Distinct())
                Console.WriteLine(categoryId);
            #endregion

            #region Count
            //Ürün listesinin toplam sayısı
            int toplamSayi = list.Count();
            Console.WriteLine("Toplam Sayi: " + toplamSayi);

            //Önce filtreledik sonra filtreden geçenlerin sayısını aldık
            Console.WriteLine("sayi2: " + list.Where(p=> p.UnitPrice > 50).Count());

            //Where'den sonra Count'u çağırmak yerine, yalnızca Count'u çağırıp filtrelemeyi bu methoda parametre geçebiliriz.
            Console.WriteLine("sayi3: " + list.Count(p=> p.UnitPrice > 50));

            //Kaç farklı CategoryId var?
            Console.WriteLine("sayi4: " + list.Select(p => p.CategoryID).Distinct().Count());
            #endregion

            #region Sum ve Average Methodları
            //Ürünlerin toplam fiyatını alalım
            Console.WriteLine("toplam: " + list.Sum(p=> p.UnitPrice));

            //Ürünlerin toplam stok değerini alalım
            Console.WriteLine("toplam stok: " + list.Sum(p => p.UnitsInStock));

            //CategoryId'si 2 olan ürünlerin toplam fiyatı
            Console.WriteLine("toplam fiyat: " + list.Where(p=> p.CategoryID == 2).Sum(p => p.UnitPrice));

            //Tüm ürünlerin ortalama fiyatı
            Console.WriteLine("ortalama fiyat: " + list.Average(p => p.UnitPrice));

            //ProductName içerisinde "a" harfi geçenlerin ortalama fiyatını alalım
            Console.WriteLine("ortalama fiyat: " + list.Where(p=>p.ProductName.Contains("a")).Average(p => p.UnitPrice));
            #endregion

            #region Max ve Min Methodları
            //En pahalı ürün
            Console.WriteLine("Pahalı Ürün:" + list.Max(p=> p.UnitPrice));

            //En ucuz ürün
            Console.WriteLine("Ucuz Ürün:" + list.Min(p => p.UnitPrice));

            //2 Id'li category'e ait en ucuz ürün
            Console.WriteLine("1 Kategorili En Ucuz Ürün:" + list.Where(p=> p.CategoryID == 2).Min(p => p.UnitPrice));
            #endregion

            #region Take Methodu
            //Sonuç kümesinin ilk N kaydının alınmasını sağlar.
            foreach (var p in list.OrderByDescending(p => p.UnitPrice).Take(5))
                Console.WriteLine(p.ProductName + " - " + p.UnitPrice);
            #endregion

            #region Any Methodu
            //Ürün listesinde 10 Id'li ürün var mı?
            bool durum = list.Where(p => p.ProductID == 10).Count() > 0;
            //durum = list.Count(p => p.ProductID == 10) > 0;

            //Aşağıdaki yöntem daha performanslıdır! Sadece true/false şeklinde tek bir değer döner ve koşul sağlandıktan sonra diğer kayıtları kontrol etmez!
            bool durum2 = list.Any(p => p.ProductID == 10);
            #endregion

            #region All Methodu
            //Tüm fiyatlar pozitif mi?
            //All methodunda, bir tane p'yi negatif görürse geriye false döneceğinden kalan sayılara bakmaksına gerek yoktur. Bu yüzden false'u hemen döner
            bool durum3 = list.All(p => p.UnitPrice > 0);
            #endregion

            #region Tolist Methodu
            //Sorgu çalışır ve sonuçları generic list koleksiyonuna doldurur.
            List<Products> sonuclar = list.OrderBy(p => p.ProductName).ToList();
            #endregion

            #region ToArray Methodu
            //ondanBuyukOlanlar değişkeninde SORGU SONUÇLARI YOKTUR! SORGUNUN KENDİSİ VARDIR
            IEnumerable<Products> ondanBuyukOlanlar = list.Where(p=> p.ProductID > 10);

            //sorguSonuclari değişkeninde SORGU SONUÇLARI VARDIR!
            Products[] sorguSonuclari = ondanBuyukOlanlar.ToArray();

            foreach (Products p in sorguSonuclari)
                Console.WriteLine(p.ProductName);
            #endregion

            #region First ve FirstOrDefault Methodları
            //sonuç kümesinin ilk kaydının alınmasını sağlarlar.
            //First methodu, eğer sonuç kümesinde kayıt yoksa exception fırlatır
            //FirsOrDefault methodu, eğer sonuç kümesinde kayıt yoksa varsayılan değeri (null) döner

            Products otuzdanBuyukIlkSayi = list.Where(p=> p.UnitPrice > 30).OrderBy(p=>p.UnitPrice).First();
            Console.WriteLine($"Ürün Adı: {otuzdanBuyukIlkSayi.ProductName}, Fiyat: {otuzdanBuyukIlkSayi.UnitPrice}");

            //Aşağıdaki sorgudan sonuç kümesi dönmeyeceği için First methodu hata oluşmasına sebep olacaktır.
            //Products cokBuyukSayi = list.Where(p => p.UnitPrice > 3000000).OrderBy(p => p.UnitPrice).First();

            //FirstOrDefault kullanıldığında ise sonuç kümesi dönmese de hata almak null döner
            Products cokBuyukSayi = list.Where(p => p.UnitPrice > 3000000).OrderBy(p => p.UnitPrice).FirstOrDefault();
            if (cokBuyukSayi != null)
                Console.WriteLine($"Ürün Adı: {cokBuyukSayi.ProductName}, Fiyat: {cokBuyukSayi.UnitPrice}");
            else
                Console.WriteLine("Sonuç bulunamadı!");
            #endregion

            #region First ve FirstOrDefault 2
            //Where methodunu önce çağırıp sonra First demek yerine, First methodunun aşırı yüklenmiş şekli kullanılabilir.

            //var listedekiIlkCiftSayi = list.Where(p => p.ProductID % 2 == 0).First();
            //var listedekiIlkCiftSayi2 = list.Where(p => p.ProductID % 2 == 0).FirstOrDefault();

            var listedekiIlkCiftSayi = list.First(p => p.ProductID % 2 == 0);
            var listedekiIlkCiftSayi2 = list.FirstOrDefault(p => p.ProductID % 2 == 0);
            #endregion

            //Ödev
            //Fiyatı 2'ye bölünebilen en pahalı ürünü çekip adını ekrana yazdıralım.


            Console.ReadKey();
        }
    }
}
