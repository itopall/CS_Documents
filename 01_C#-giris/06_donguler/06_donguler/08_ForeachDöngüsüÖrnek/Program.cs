using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ForeachDöngüsüÖrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            #region örnek 1
            //içerisinde ürün fiyatları bulunan bir int dizisi oluşturup değerlerini oluşturma anında atayalım.sonrasında her ürün fiyatının yüzde 10 zamn yapılmış halinin ekrana yazdırma
            //float[] fiyatListesi = { 12, 23, 78, 89, 37, 41 };
            //foreach(float zam in fiyatListesi)
            //{

            //    Console.WriteLine( zam * 10 / 100 + zam);
            //}
            #endregion

            #region örnek 2
            //5 karakter uzunluğunda bir string dizisi oluşturup değerleri oluşturma anında atayalım ve dizinin içindeki en değeri bulup ekrana yazdıralım.
            //string[] kelimeler = { "merhaba", "nasılsın", "iyidir,sen?", "dayınlar nasıl", "fena değiller." };
            //string enbuyuk = "";
            //foreach(string aranan in kelimeler)
            //{
            //    if (aranan.Length > enbuyuk.Length)
            //        enbuyuk = aranan;
            //}
            //Console.WriteLine("en uzun kelime: {0}", enbuyuk);
            #endregion
            #region örnek 3
            //diziye rastgele atanan 10 adet sayının ortalamasını bulup ekrana yazdıran program yazalım
            //Random random = new Random();
            //int[] sayilar = new int[10];
            ////int counter = 0;
            //int toplam = 0;
            //foreach(int girdi in sayilar)
            //{
            //    sayilar[girdi] = random.Next(1,100);//diizi kullandığımız için diziye atama yapma [] kullanılmak zorunda girdi yerine counter koyup sonrasında counter++ yazılmalı
            //    Console.WriteLine(sayilar[girdi]);
            //    toplam += sayilar[girdi];
            //}
            //foreach (int girdi in sayilar)
            //     toplam += girdi;
            //Console.WriteLine("ortamala : {0}",toplam / sayilar.Length);
            #endregion

            #region örnek 4
            // 5 karkater uzunluğunda bir string dizisi oluşturup klavyeden 5 değerin girilmesini şağlayıp dizinin içerisindeki büütn harfleri alt alta ekrana yazdıran program yazalım
            //string[] kelimeler = new string[5];
            //int counter = 0;
            //foreach (string kelime in kelimeler)
            //{
            //    Console.Write("kelime giriniz: ");
            //    kelimeler[counter] = Console.ReadLine();// a int değer olmak zorunda
            //    counter++;
            //}
            //foreach(string kelime in kelimeler)
            //{
            //    foreach (char harf in kelime)
            //        Console.WriteLine(harf);
            //    Console.WriteLine();
            //}
            
            #endregion

            Console.ReadKey();
        }
    }
}
