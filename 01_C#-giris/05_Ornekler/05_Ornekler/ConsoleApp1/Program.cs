using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            // soru: kullanıcıdan öncelikle isim sonra sonra soyisim isteiyip girilen isim ve soy isim bilgilerinin yan yana ekrana yazan programı yazalım.

            //Console.Write("isminizi giriniz: ");
            //string isim = Console.ReadLine();
            //Console.Write("soy isiminizi giriniz: ");
            //string soyisim = Console.ReadLine();
            //Console.WriteLine("isim: {0} soyisim: {1}" , isim , soyisim);
            #endregion

            #region örnek 2
            // kullanıcıdan 2 adet sayı girmesini isteyerek bu sayıların toplamını,farkını çarpını bölümünü ve bölümünden kalanı ekrana yazdıran programı yazalım
            //Console.Write("1. sayıyı giriniz: ");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz: ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("toplam: {0}" , sayi1+sayi2);
            //Console.WriteLine("fark: {0}", sayi1 - sayi2);
            //Console.WriteLine("çarpım: {0}", sayi1 * sayi2);
            //Console.WriteLine("bölüm: {0}", Math.Round(sayi1 / sayi2,2));
            //Console.WriteLine("kalan: {0}", sayi1 % sayi2);
            #endregion

            #region örnek 3
            // klavyeden girilen sayının küpünü bulup ekrana yazdıran programı yazalım
            //Console.Write("1. sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sayıynın küpü: {0}", Math.Pow(sayi1, 3));
            #endregion

            #region örnek 4
            // kullanıcının girdiği ürün fiyat bilgisinin kdv'sinin (%18) hesaplayıp ekrana  yazdıran ve kdv dahil fiyatını da ekrana yazdıran programı yazalım
            //Console.Write("ürün fiyatını giriniz: ");
            //double fiyat = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("kdv'si: {0}",fiyat * 0.18);
            //Console.WriteLine("kdv dahil fiyat:{0}", fiyat * 0.18 + fiyat);
            #endregion

            #region örnek 5
            // klavyeden alış fiyatı ve kar oranı bilgileri girlen bir ürünün satış fiyatını hesaplayıp ekrana yazdıran programı yazalım
            //Console.Write("ürün fiyatını giriniz: ");
            //double fiyat = Convert.ToDouble(Console.ReadLine());
            //Console.Write("kar oranını giriniz: ");
            //double kof = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("satış fiyatı: {0}", (fiyat * kof/100) + fiyat);

            #endregion

            #region örnek 6
            // klavyeden girilen sayının negatif mi pozitif mi olup olmadığını ekrana yazdıran program
            //Console.Write("sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi < 0)
            //    Console.WriteLine("sayı negatiftir");
            //else if (sayi > 0)
            //    Console.WriteLine("sayı pozitiftir");
            //else
            //    Console.WriteLine("sayı sıfır(0)'dır.");
            #endregion

            #region örnek 7
            // klavyeden girilen sayının 5 'e ve /'ye tam bölünüp bölünmediğini bulan programı yazalım
            //Console.Write("bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 5 == 0 && sayi % 7 == 0)
            //Console.WriteLine("sayı 5 ve 7' nin katıdır."); 
            //else
            //Console.WriteLine("sayı 5 ve 7'nin katı değildir"); 
            #endregion

            #region örnek 8
            // klavyeden girilen sayının 0-1000 arasında olup olmadığını kontrol eden program
            //Console.Write("sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi >= 0 && sayi <= 1000)
            //    Console.WriteLine("sayı 0-1000 arasındadır");
            //else
            //    Console.WriteLine("sayı 0-1000 arasında değildir");
            #endregion

            #region örnek 9
            //klavyeden girilen cümledeki virgül ","karakterini nokta "." karakteri ile değiştiren programı yazalım
            //Console.Write("Virgül içeren cümle giriniz: ");
            //string cumle = Console.ReadLine();
            // Console.WriteLine("yeni cümle:{0}", cumle.Replace(',', '.'));
            #endregion

            #region örnek 10
            // klavyeden yaş bilgisi istenerek eğer yaş 18 ve üstü ise "Ehliyet alabilir " değilse "ehliyet alamazsınız " ehliyet içimm kaç yıl kaldığını yazınız
            //Console.Write("yaş giriniz: ");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //if (yas >= 18)
            //    Console.WriteLine("Ehliyet alabilirsiniz");
            //else

            //    Console.WriteLine("ehliyet alamazsınız. {0} sene sonra alabilirsiniz.", 18 - yas);

            #endregion

            #region örnek 11
            // klavyeden girilen sayı çift ise yarısını tek ise iki katını alarak ekrana yazdırma
            //Console.Write("sayi giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //    Console.WriteLine("sayının yarısı: {0}", sayi / 2);
            //else if (sayi % 2 == 1)
            //    Console.WriteLine("sayının iki katı: {0}", sayi * 2);
            #endregion

            #region örnek 12
            // daha önceden değişkenlere atanarak belirlene kullanıcı adı ve şifre bilgilerimiz olsun 
            //klavyeden login ekranında olması gerektiği gibi kullanıcı adı ve şifre bilgilerinin girilmesi isteyelim.Giriilen değerler bizim belirlediklerimizle aynı ise "giriş başarılı anasayfaya yönlendiriliyorsunuz"yazsın aynı değilse kullanıcı adı yada şifre yanlış" yazsın
            //string kullanıcıadı = "ilker";
            //string sifre = "12345" ;
            //Console.Write("kullanıcı ismi gir: ");
            //string id = Console.ReadLine();
            //Console.Write("şifre gir: ");
            //string pass = Console.ReadLine();
            //if (kullanıcıadı == id && sifre == pass)
            //    Console.WriteLine("giriş ekranına yönlendiriliyorsunuz...");
            //else
            //    Console.WriteLine("şifre ya da kullanıcı adı yalnış.");


            #endregion

            #region örnek 13
            //klavyeden girilen bir string değerin boşluk karakterine kadar olan kısmını ekrana yazdırma programı
            //Console.Write("cümle giriniz:");
            //string cumle = Console.ReadLine();
            //string[] kelimeler = cumle.Split(' ');
            //Console.WriteLine(kelimeler[0]);
            //int no = cumle.IndexOf(' ');
            //Console.WriteLine(cumle.Substring(0,no));
            #endregion

            #region örnek 14
            //kullanıcıdan 2 adet sayı girmesi istenecek sonrasında ise işlem tipleri ekrana yazdırılıcak ve işlem türünü seçmesi istenecek.son olarak girilen rakamlar seçilen işlem türne göre hesaplanarak ekrana yazılacak
            //Console.Write("1. sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("işlem tipi giriniz (+,-,*,/,%): ");
            //char karakter = Convert.ToChar(Console.ReadLine());
            //if (karakter == '+')
            //    Console.WriteLine(sayi1 + sayi2);
            //else if (karakter == '-')
            //    Console.WriteLine(sayi1 - sayi2);
            //else if (karakter == '*')
            //    Console.WriteLine(sayi1 * sayi2);
            //else if (karakter == '/')
            //    Console.WriteLine(sayi1 / sayi2);
            //else if (karakter == '%')
            //    Console.WriteLine(sayi1 % sayi2);
            //switch (karakter)
            //{
            //    case '+':
            //        Console.WriteLine(sayi1 + sayi2);
            //        break;
            //    case '-':
            //        Console.WriteLine(sayi1 - sayi2);
            //        break;
            //    case '*':
            //        Console.WriteLine(sayi1 * sayi2);
            //        break;
            //    case '/':
            //        Console.WriteLine(sayi1 / sayi2);
            //        break;
            //    case '%':
            //        Console.WriteLine(sayi1 % sayi2);
            //        break;
            //}

            #endregion

            #region örnek 15
            // klavyeden girile doğum tarihinin girilmesi isteyerek gelen tarihe göre yaş analizi yapan programı yapalım
            //0-10,11-20, 21-30, 31-40, 41-50, 50 yaş üstü şekilnde çıktı versin
            //Console.Write("doğum tarihinizi gün.ay.yıl şeklinde giriniz: ");
            //DateTime dt = Convert.ToDateTime(Console.ReadLine());

            //TimeSpan ts = DateTime.Now - dt;
            //int yas = (int)ts.TotalDays / 365;
            //if (yas >= 0 && yas <= 10)
            //    Console.WriteLine("yaş 0-10 arasıdır.");
            //else if (yas >= 11 && yas <= 20)
            //    Console.WriteLine("yaş 11-20 arasıdır.");
            //else if (yas >= 21 && yas <= 30)
            //    Console.WriteLine("yaş 21-30 arasıdır.");
            //else if (yas >= 31 && yas <= 40)
            //    Console.WriteLine("yaş 31-40 arasıdır.");
            //else if (yas >= 41 && yas <= 50)
            //    Console.WriteLine("yaş 41-50 arasıdır.");
            //if (yas >= 50)
            //    Console.WriteLine("50 yaş üstüdür");

            #endregion

            #region örnek 16
            // klavyeden girilen bir cümleyi kelimelerine ayırarak 2. kelimeyi büyük harfe çevirip başına ve sonua "_Test_" ekleyip ekrana yazdıran programı yazalım
            //Console.Write("cümle giriniz: ");
            //string cumle = Console.ReadLine();
            //string[] kelimeler = cumle.Split(' ');
            //Console.WriteLine("_test_{0}_test_", kelimeler[1].ToUpper());



            #endregion

            #region
            //klavyeden girilen değerin boş yada  null olup olmadığını kontrol eden değilse metnin ilk yarınsını silip kalan yarısını 2. ve 3. karakterini ekrana yazdıran programı yazalım.
            //ipucu string bir değişkenin uzunluğunu bulmak için değisşkenadi.length i kullanabilriz
            #endregion

            #region
            //1 den 10 a kadar olan sayıları içerisinde bulunduran bir dizi oluşturup 5 sayısı yerine 20 atayıp ekrana yazdıran program
            #endregion
            Console.ReadKey();
        }
    }
}
