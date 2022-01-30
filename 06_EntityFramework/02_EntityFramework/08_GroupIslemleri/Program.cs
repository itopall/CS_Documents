using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_GroupIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities context = new NORTHWNDEntities();

            #region Query Operatörü
            //group by p.CategoryId into g => Her bir Products tipinden nesneyi, CategoryId property'sinin değerine göre gruplandırır.

            var sorgu1 = from p in context.Products.ToList()
                         group p by p.CategoryID into g1
                         select g1.Count();

            var sorgu2 = from p in context.Products.ToList()
                         group p by p.CategoryID into g2
                         select g2.Sum(p => p.UnitPrice);

            foreach (var item in sorgu2)
                Console.WriteLine(item.Value);
            #endregion

            #region Örnek 1
            IEnumerable<IGrouping<int?, Products>> sorgu3 = from p in context.Products.ToList()
                                                            group p by p.CategoryID into g3
                                                            orderby g3.Count()
                                                            select g3;
            #endregion

            #region Örnek 2
            var sorgu4 = from p in context.Products.ToList()
                         group p by p.CategoryID into g4
                         select g4;

            int grupSayisi = sorgu4.Count();
            IGrouping<int?, Products> productGroup = sorgu4.First(); //var da kullanabilirdik.

            Console.WriteLine("Toplam Fiyat: " + productGroup.Sum(p=> p.UnitPrice));
            Console.WriteLine("Ürün Sayısı: " + productGroup.Count());
            #endregion

            #region Gruplarda Gezmek
            var kategoriGruplari = context.Products.ToList().GroupBy(p => p.CategoryID);
            foreach (var grup in kategoriGruplari)
            {
                Console.WriteLine("Key: " + grup.Key);
                Console.WriteLine("Ürün Sayısı: " + grup.Count());
                Console.WriteLine("Fiyatlar Toplamı: " + grup.Sum(p=>p.UnitPrice));
                Console.WriteLine("Ortalama Fiyat: " + grup.Average(p => p.UnitPrice));
                Console.WriteLine("***************************************************************************");
            }
            #endregion

            #region Bir grupta gezme
            var g = kategoriGruplari.First();
            foreach (Products product in g)
                Console.WriteLine(product.ProductName);
            #endregion

            #region ElementAt Methodu
            //Grup listesindeki ikinci index'de bulunan grup'u elde ettik.
            var ikinciGrup = kategoriGruplari.ElementAt(1);

            //Key
            //1
            //    ProductId, ProductName
            //    1           Chai
            //    2           Chang
            //    24          Guaraná Fantástica
            //2
            //    ProductId, ProductName
            //    2           Aniseed Syrup
            //    4           Chef Anton's Cajun Seasoning
            //    5           Chef Anton's Gumbo Mix
            //3
            //4
            //5
            //6
            //7
            //8
            //null
            #endregion

            #region Paging Örneği
            foreach (var kategoriGrup in kategoriGruplari)
            {
                Console.WriteLine(kategoriGrup.Key);
                Console.WriteLine(kategoriGrup.Count());

                foreach (var product in kategoriGrup)
                {
                    Console.WriteLine(product.ProductName);
                }

                Console.WriteLine("Sonraki sayfaya geçmek için bir tuşa basınız...");
                Console.ReadKey();
                Console.Clear();
            }
            #endregion

            Console.ReadKey();
        }
    }
}
