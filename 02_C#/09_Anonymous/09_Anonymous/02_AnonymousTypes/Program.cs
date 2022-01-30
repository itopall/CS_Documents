using System;

namespace _02_AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tasarımı yapılmamış tiplere ait nesnelrin oluşturulmasını sağlar.
            // Anonymous tipler kullan at tarzındaki sınıflarda sıkça kullanılır. Linq ve entity framework konularında göreceğiz.
            
            //Urun sınıfı yazmadan belleğe Id, Ad, Fiyat propertlerine sahip nesne çıkardık ve bu nesnenin adresini urun'de sakladık

            //Sağ taraftan gelen nesnenin tip ismi görülmediğinden dolayı urun değişkeninin tip adı verilmeden tanımlanır yani "var" KUllanılır.

            //Anonim nesneye bakarak compler sınıfı otomatik yazar!Ancak yazılanın bu sınıfın adı kodlama tarafında kullanılmaz.

            var urun = new { Id = 10, Ad = "laptop", Fiyat = 10000 };
            Console.WriteLine(urun.Ad);

            var araba = new { Marka = "Mercedes", Model = "GLA200" };
            Console.WriteLine(araba.Model);

            var araba2 = new { Marka = "BMW", Model = "4.20" , Renk = "Parlament Mavisi"};
            Console.WriteLine(araba2.Model);

            // İç içe anonim tipler de tanımlayabiliriz.
            var kitap = new
            {
                Id = 1,
                Ad = "Satranç",
                SayfaSayisi = 70,
                Yazar = new { AdSoyad = "Stefan Zweig", Yas = 50, Memleket = "Almanya" }
            };
            Console.WriteLine(kitap.Yazar.AdSoyad);
            Console.WriteLine(kitap);


            Urun urn = new Urun();
            urn.Id = 1;
            urn.Name = "Laptop";

            //urn.Category = new Category; Urun sınıfının içindeki ctor'u yazmayıp bunuda yazabliriz
            urn.Category.CategoryId = 10;
            urn.Category.CategoryName = "Bilgisayar";

            Category c = urn.GetCategory();
            Console.WriteLine("{0} - {1}",c.CategoryId,c.CategoryName);

            Console.ReadKey();
        }
    }

    //Normal class tasarımıyla iç-içe kullanım
    //Bir classın içerisinde başka bir class'ı property tipi,methodun içerisinde return tip ya da parametre tipi olarak kullanabiliriz.
    //Aşağıda Category Class'ı Urun class'ının içersinde property tipi ve GetCategory methodunun return tipi olarak kullanılmış
    class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category Category { get; set; }

        public Urun()
        {
            Category = new Category();
        }

        public Category GetCategory()
        {
            //Db'ye gidilip ilgili ürüne ait category bilgileri çekilp Category nesnesi olarak return edilir.
            Category c = new Category();
            c.CategoryId = 1;
            c.CategoryName = "Laptop";
            return c;
        }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

}
