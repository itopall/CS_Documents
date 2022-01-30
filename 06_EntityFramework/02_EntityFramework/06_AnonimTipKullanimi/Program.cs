using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_AnonimTipKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities context = new NORTHWNDEntities();
            var list = context.Products.ToList();

            #region Örnek Select Cümleleri
            IEnumerable<Products> sonuclar1 = list.Where(p => p.UnitPrice > 100);
            IEnumerable<string> sonuclar2 = list.Where(p => p.UnitPrice > 100).Select(p => p.ProductName);
            IEnumerable<decimal?> sonuclar3 = list.Select(p => p.UnitPrice);
            #endregion

            #region Anonim Tip Olmasaydı!
            IEnumerable<ProductSummary> sonuclar4 = list.Where(p => p.UnitPrice > 100)
                .Select(p => new ProductSummary { ProductName = p.ProductName, UnitPrice = p.UnitPrice });

            foreach (ProductSummary ps in sonuclar4)
                Console.WriteLine($"ProductName: {ps.ProductName} - Price: {ps.UnitPrice}");
            #endregion

            #region Anonim Tip Kullanımı - Örnek 1
            var sonuclar5 = list.Where(p => p.UnitPrice > 100)
                .Select(p => new { ProductName = p.ProductName, UnitPrice = p.UnitPrice });

            foreach (var ps in sonuclar5)
                Console.WriteLine($"ProductName: {ps.ProductName} - Price: {ps.UnitPrice}");
            #endregion

            #region Anonim Tip Kullanımı - Örnek 2
            //Kategorisi 1 olan UnitPrice'ı 100'den büyük olan ürünleri, adlarına göre alfabetik olarak sıralayıp, bu ürünlerin sadece ID ve ADLARINI SELECT edelim!

            var sonuclar6 = list.Where(p => p.CategoryID == 1111 && p.UnitPrice > 100).OrderBy(p => p.ProductName)
                .Select(p => new { pId = p.ProductID, pName = p.ProductName });

            foreach (var p in sonuclar6)
                Console.WriteLine($"Id:{p.pId} - Name:{p.pName}");
            #endregion

            #region Anonim Tip Kullanımı - Örnek 3
            //UnitPrice'ı, listenin ortalama UnitPrice'ının üzerinde olan ürünlerin, sadece ProductName ve UnitPrice değerlerini select edelim.
            var ort = list.Average(p => p.UnitPrice);

            //Not: Anonim nesne select ederken, seçilen property isimleriyle tanımlanan property isimleri birebir aynıysa property'lerin adını yazmaya gerek yoktur. Yani "new { Ad = p.ProductName }" demek yerine "{ p.ProductName }" diyebiliriz.
            var sonuclar7 = list.Where(p => p.UnitPrice > ort).Select(p => new { p.ProductName, p.UnitPrice });

            foreach (var p in sonuclar7)
                Console.WriteLine($"Name:{p.ProductName} - Price:{p.UnitPrice}");
            #endregion

            #region Anonim Tip Kullanımı Query Operatör
            var ort2 = list.Average(p => p.UnitPrice);
            var sonuclar8 = from p in list
                            where p.UnitPrice > ort2
                            orderby p.UnitPrice
                            select new { p.ProductName, p.UnitPrice };
                            #endregion

            Console.ReadKey();
        }
    }

    class ProductSummary
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
