using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WhileDongusu_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            #region örnek 1 
            // while döngüsü kullanarak kullanıcadan 5 adet sayı girmesini isteyip girilen sayıların toplamını ekrana yazdırma

            //int toplam = 0;
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.Write("sayı giriniz: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //    i++;
            //}
            //Console.WriteLine(toplam);
            #endregion

            #region örnek 2
            // kullanıcıdan sıyı girmesini isteyen ve girilen sayıların toplamını alan sonrasında "devam etmek istiyor musunuz " diye soran cevap olarak "e" gelmesi durumunda aynı işlemi tekrar yapıp en sonunda döngüden çıkınca toplam değeri ekrana yazdıran programı yapınız.
            //int toplam = 0;
            //string devametsinmi = "E";
            //while (devametsinmi == "E")
            //{
            //    Console.Write("sayı giriniz: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //    Console.Write("Devam etmek istiyor musun? E/H: ");
            //    devametsinmi = Console.ReadLine();

            //}
            //Console.WriteLine("Döngüden çıkıldı.Toplam sayı değeri = {0}",toplam);
            #endregion

            #region örnek 3
            // 3 karakter uzunluğunda bir int dizisi oluşturup kullanıcıdan klavyeden 3 tane rakam girilmesini isteyerek girilen rakamları diziye ekleyen ve sonrasında dizi elemanlarını ters çeviren en büyük en küçük toplam ve ortalama değeri bulup ekrana yazdıran program
            //int[] sayilar = new int[3];
            //int i = 0;
            //int i2 = 0;
            //while (i < sayilar.Length)
            //{
            //    Console.Write("sayı giriniz: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //    i++;
            //}
            //Array.Reverse(sayilar);
            //while(i2 < sayilar.Length)
            //{
            //    Console.WriteLine(sayilar[i2]);
            //    i2++;
            //}
            //Console.WriteLine("ortamala: {0} ", sayilar.Average());//ortalama
            //Console.WriteLine("en büyük: {0} ",sayilar.Max());
            //Console.WriteLine("en küçük: {0} ", sayilar.Min());
            #endregion

            #region örnek 4
            // login kontrolü örneği
            //klavyeden kullanıcı adı ve sifre isteyerek 3 kez hatalı giriş yapılması durumunda hesabınız kilitlenmiştir uyarısı vererek çıkış yapan giriş bilgileri doğru ise login işlemi başarılı anasayfaya yönlendiriliyorsunuz yazan programı yazalım 
            // kıyaslamalar daha önceden değişkenlere atanarak belirlenmiş username ve password değişkenleriyle yapılacak
            //string username = "admin";
            //string password = "1903";
            //int counter = 0;
            //while (true)
            //{
            //    Console.Write("kullanıcı adınızı giriniz: ");
            //    string comingUserName = Console.ReadLine();

            //    Console.Write("şifrenizi giriniz: ");
            //    string comingPassword = Console.ReadLine();
            //    if (comingUserName == username && comingPassword == password)
            //    {
            //        Console.WriteLine("Login işlemi başarılı, anasayfaya yönlendiriliyorsunuz...");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("kullanıcı adı yada şifre yanlıştır.");
            //        counter++;
            //        if (counter == 3)
            //        {
            //            Console.WriteLine("hesabınız kitlenmiştir");
            //            break;
            //        }
            //    }
            //}
            #endregion








            Console.ReadKey();
        }
    }
}
