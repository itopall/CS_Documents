using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ImplictlyTypeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 5, 10, 15, 20 };
            double[] ondaliklar = new double[] { 10.2, 20.5, 30.7 };

            var dizi = new[] { 12.2, 20.5, 30.7 };
            var dizi2 = new[] { "asd", "dsa", "qwe" };

            //bilinçsiz tanımlanan dizilerde objet en iyi tip olmaz!Aşağıdaki satır derlemee zamanında hata alır!
            //var dizi3 = new[] { 4, 5.5, "qww", true };

            //Bilinçsiz tanımlanan diziler (tip adı verilmeden tanımlanan diziler), anonim tiplerin dizilerini yapabilmek için kullanılı
            var dizi4 = new[]
            {
                new { Id = 1, Ad = "Laptop", Fiyat = 10000 },
                new { Id = 2, Ad = "klavye", Fiyat = 200 },
                new { Id = 3, Ad = "Mouse", Fiyat = 100 }
            };
            foreach (var item in dizi4)
                Console.WriteLine(item.Ad);

            for (int i = 0; i < dizi4.Length; i++)
                Console.WriteLine(dizi4[i]);

            #region Örnek
            //Anonim olarak kategoriler dizisi oluşturalım. Her bir kategori içerisinde (Id,Name, Urunler) propertyleri olsun. Urun tipi(Id,Name, Price) propertlerinden oluşşsun
            //Dizinin içerisinde 2 tane örnek kategori her kategorinin içine de en az 2 tane urun bilgisi ekleyip sonrasında bu bilgileri ekrana yazdıralım
      
            #endregion


            Console.ReadKey();
        }
    }
}
