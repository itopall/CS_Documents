using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            ////Klavyeden bilgi isteme
            //Console.Write("Sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            ////Koşullar 
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayı 0'dan büyüktür");
            //}
            //else if (sayi < 10)
            //{
            //    Console.WriteLine("Sayı 10'dan küçüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 0'dan büyük ya da 10'dan küçük değildir.");
            //}
            #endregion

            #region Switch Case
            //int plakaKodu = 1111;
            //switch (plakaKodu)
            //{
            //    case 16:
            //        Console.WriteLine("Şehir Bursa'dır");
            //        break;
            //    case 6:
            //        Console.WriteLine("Şehir Ankara'dır");
            //        break;
            //    case 34:
            //        Console.WriteLine("Şehir İstanbul'dur");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı bir değer girdiniz");
            //        break;
            //}
            #endregion

            #region For Döngüsü
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //        continue;

            //    if (i == 7)
            //        break;

            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region while Döngüsü
            //string devamEtsinMi = "E";
            //while (devamEtsinMi == "E")
            //{
            //    Console.WriteLine("Bi tur döndü...");

            //    Console.Write("Devam etmek istiyor musunuz? (E/H): ");
            //    devamEtsinMi = Console.ReadLine();
            //}
            #endregion

            #region do while Döngüsü
            //string tekrarCalistir = "E";
            //do
            //{
            //    Console.WriteLine("Uygulama çalıştırıldı...");

            //    Console.Write("Tekrar çalıştırmak istiyor musunuz? (E/H): ");
            //    tekrarCalistir = Console.ReadLine();

            //} while (tekrarCalistir == "E");
            #endregion

            #region Foreach Döngüsü
            //string cumle = "Ali ata bak";
            //foreach (char harf in cumle)
            //{
            //    Console.WriteLine(harf);
            //}

            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            #endregion

            #region Methodlar
            //Topla();
            //Topla(10, 20);
            //Topla(10.2, 20.2);
            //Cikar(100, 50);
            #endregion

            #region out keyword
            //int a;
            //int b;
            //DegerGuncelle(out a, out b);
            //Console.WriteLine($"a: {a}, b: {b}");

            //int aa = 10;
            //int bb = 20;
            //DegerGuncelleRef(ref aa, ref bb);
            //Console.WriteLine($"aa: {aa}, b: {bb}");

            #endregion

            #region Params keyword
            //string[] words = { "masa", "sandalye", "klavye" };
            //DiziYazdir(words);

            //DiziYazdir("masa", "sandalye", "klavye");
            //Console.WriteLine("{0}", true);
            //Console.WriteLine("{0}, {1}", true, DateTime.Now);
            #endregion

            #region Optional ve Naming parameter
            //PersonelOlustur("Ekrem Öztürk", 31, "Eğitmen");
            //PersonelOlustur("Rümeysa Koral", 23);
            //PersonelOlustur("Rüştü Dinç", 26);

            //PersonelOlustur(yas: 20, isimsoyisim: "Berat Yurdakul");
            #endregion

            #region Exception Management

            //try
            //{
            //    string str = null;
            //    str.Remove(0);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata: " + ex.Message);
            //    Console.WriteLine("Stack Trace: " + ex.StackTrace);
            //}

            //try
            //{
            //    string str = null;
            //    //str.Remove(10);

            //    //if (str == null)
            //    //    throw new ArgumentNullException("str", "Değer null olamaz!");
            //}
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine("Hata: " + ex.Message);
            //    Console.WriteLine("Stack Trace: " + ex.StackTrace);
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine("Hata: " + ex.Message);
            //    Console.WriteLine("Stack Trace: " + ex.StackTrace);
            //}
            //catch (StackOverflowException ex)
            //{
            //    Console.WriteLine("Hata: " + ex.Message);
            //    Console.WriteLine("Stack Trace: " + ex.StackTrace);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata: " + ex.Message);
            //    Console.WriteLine("Stack Trace: " + ex.StackTrace);
            //}
            //finally
            //{
            //    Console.WriteLine("Her halükarda çalışır");
            //}
            #endregion

            #region Enum
            //Console.WriteLine(Sehirler.Bursa);
            //Console.WriteLine((int)Sehirler.Bursa);

            //Sehirler s1 = (Sehirler)6;
            //Console.WriteLine(s1);
            #endregion

            Console.ReadKey();
        }

        static void Topla()
        {
            Console.Write("1. sayiyi giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayiyi giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam: " + (sayi1 + sayi2));
        }

        //Topla methodunun overload'ları
        static void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine("Toplam: " + (sayi1 + sayi2));
        }

        static void Topla(double sayi1, double sayi2)
        {
            Console.WriteLine("Toplam: " + (sayi1 + sayi2));
        }

        //return veren method
        /// <summary>
        /// Gelen iki sayinın farkını alıp sonucu geri döner
        /// </summary>
        /// <param name="sayi1">1. sayi</param>
        /// <param name="sayi2">2. sayi</param>
        /// <returns></returns>
        static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        static void DegerGuncelle(out int sayi1, out int sayi2)
        {
            //Console.WriteLine(sayi1);

            sayi1 = 1000;
            sayi2 = 2000;

            Console.WriteLine(sayi1);
        }

        static void DegerGuncelleRef(ref int sayi1, ref int sayi2)
        {
            Console.WriteLine(sayi1);

            sayi1 = 1000000;
            sayi2 = 2000000;
        }

        static void DiziYazdir(params string[] kelimeler)
        {
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
        }

        static void PersonelOlustur(string isimsoyisim, int yas, string yetki = "Öğrenci")
        {
            Console.WriteLine($"İsim Soyisim: {isimsoyisim}, : Yaş: {yas}, Yetki: {yetki}");
        }


        enum Sehirler : int
        {
            Istanbul = 34,
            Ankara = 6,
            Bursa = 16,
            Izmir = 35
        }
    }
}
