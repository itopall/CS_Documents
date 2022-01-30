using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_StringIslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bir karakteri iztediğimiz miktarda ekrana yazdırmak.
            string harfler = new string('A', 100);
            Console.WriteLine(harfler);
            #endregion

            #region ToUpper
            //girilen değerleri büyük harfe çevirir.
            string kelime = "büyük yazı";
            Console.WriteLine(kelime.ToUpper());

            #endregion

            #region ToLower
            //girilen değerleri büyük harfe çevirir.
            string kelime2 = "KÜÇÜK YAZI";
            Console.WriteLine(kelime2.ToLower());
            #endregion

            #region  StartsWith & EndsWith
            string kelime3 = "örnek kelime";
            bool sonuc = kelime3.StartsWith("ö"); // ilk harfi ö ise true döner
            Console.WriteLine(sonuc);


            bool sonuc2 = kelime3.EndsWith("e"); // son harf e ise true değilse false döner.
            Console.WriteLine(sonuc2);
            #endregion
            
            #region Replace

            //string bir değerin belirlenen karakterlerinin yeni değerler ile değiştirilmesini sağlar.
            string kelime4 = "www.ucuncubinyil.com";
            string sonuc3 = kelime4.Replace("com", "org");
            Console.WriteLine(sonuc3);
            #endregion

            #region Remove
            //belirlenen kriterlere göre bazı karakterleri silmeye yarar.
            string kelime5 = "www.ucuncubinyil.com";
            string sonuc4 = kelime5.Remove(4);//4. index'ten itibaren siler.
            Console.WriteLine(sonuc4);
            Console.WriteLine(kelime5.Remove(4)); // bu kullaımda mümkün.
            Console.WriteLine(kelime5.Remove(4, 12));//4. index'ten itibaren 12 karakter sil
            #endregion

            #region SubString
            //Belirlenen kriterlere göre bazı karakterleri elde etmeye yarar.
            string kelime6 = "www.ucuncubinyil.com";
            Console.WriteLine(kelime6.Substring(4));
            Console.WriteLine(kelime6.Substring(4,12));
            #endregion

            #region Trim
            // string bir değerin başındaki ve sonundaki boşlukları temizler.
            string kelime7 = "      boşluk      ";
            Console.WriteLine(kelime7);
            Console.WriteLine(kelime7.Trim());
            Console.WriteLine(kelime7.TrimStart());//TrimStart başındaki boşlukları siler
            Console.WriteLine(kelime7.TrimEnd());//TrimEdn sonundaki boşlukları siler.

            #endregion

            #region string format
            //string değerleri içerisinde {0} {1} şekilndeki formatlı kullanıma olanak sağlar.
            string ogrenci1 = "bahadır";
            string ogrenci2 = "rumeysa";
            string ogrenci3 = "utku";
            Console.WriteLine("Öğrenci1: " + ogrenci1 + " Öğrenci2: " + ogrenci2 + " Öğrenc3: " + ogrenci3);

            string cumle = string.Format("Öğrenci1: {0} Öğrenci2:{1} Öğrenci3:{2} ", ogrenci1, ogrenci2, ogrenci3);
            #endregion

            #region IsNullOrEmpty
            //String değerin null ya da empty yani boş olma durumunu kontrol eder
            string kelime8 = null;
            string kelime9 = "";
            string kelime10 = string.Empty;// Üst satır ile aynı anlama gelir
            string kelime11 = "test";

            // Dönen sonuç true ise string değer null ya da empty demektir.
            Console.WriteLine(string.IsNullOrEmpty(kelime8));
            Console.WriteLine(string.IsNullOrEmpty(kelime9));
            Console.WriteLine(string.IsNullOrEmpty(kelime10));
            Console.WriteLine(string.IsNullOrEmpty(kelime11));

            #endregion

            #region Compare
            //İki string değişken aynı olup olmadığını kontrol eder
            string kelime12 = "karşılaştırma";
            string kelime13 = "karŞılaştırma";

            //Büyük - küçük harf dikkate alsın istiyorsak aşağıdaki yöntemi kullanabiliriz
            int sonuc5 = string.Compare(kelime12, kelime13);// Sonuç 0 dönerse kelimeler aynı demektir
            Console.WriteLine(sonuc5);

            //büyük - küçük harf dikkate almamasını istiyorsak aşağıdaki yöntemi kullanabiliriz.
            int sonuc6 = string.Compare(kelime12, kelime13, true);//sonuç 0  dönerse kelimeler aynı demektir
            Console.WriteLine(sonuc6);
            #endregion

            #region Split
            //string bir değerinin belirlenen karaktere göre bölünerek stirng dizisine çevrilmesini sağlar.
            string cumle2 = "Bu uzun bir cümledir";
            string [] kelimeler = cumle2.Split(' ');
            Console.WriteLine("Cümle2'deki kelime sayısı: {0}",kelimeler.Length);
            #endregion

            






            Console.ReadKey();
        }
    }
}
