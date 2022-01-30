using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HataYönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region try-catch kullanımı -1
            //try-catch bloğu hata yöentimi uygulamak istediğimiz riskli olabilecek kod bloklarını kontrol altında tutmak için uygulanır.
            //try
            //{
            //    Console.Write("bir sayı giriniz: ");
            //    int gelenSayi = int.Parse(Console.ReadLine());
            //    Console.WriteLine(gelenSayi);
            //}
            //catch
            //{
            //    Console.WriteLine("Hatalı bir değer girdiniz!");
            //}
            #endregion

            #region try-catch kullanımı -2 
            //try
            //{
            //    Console.Write("sayı giriniz: ");
            //    int gelenSayi = int.Parse(Console.ReadLine());// null gönderilirse = ArgumentNullException catch bloğuna düşer
            //    Console.WriteLine(gelenSayi);
            //}
            //catch(FormatException)// try içerisinde FormatException hatası meydana gelirse, bu catch bloğuna çalışır
            //{
            //    Console.WriteLine("Lütfen harf yada özel karakter kullanmadan bir tam sayı giriniz.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Lütfen {0} ile {1} arasında bir tam sayı giriniz.", int.MinValue, int.MaxValue);
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("Lütfen null olmayan bir değer giriniz!");
            //}
            //catch//yukarıdaki catch blokları dışında başka bir hata meydana gelirse bu cathc bloğu çalışır
            //{
            //    Console.WriteLine("beklenmeyen bir hata oluştu! lütfen daha sonra tekrar deneyiniz.");
            //}
            // Parse methodu 3 farklı exception fırlatabilir, bunları Parse methodu üzerine geldiğinde çıkan tooltip ile görebiliriz.
            #endregion

            #region try- catch kullanımı-3
            //try
            //{
            //    Console.Write("sayı giriniz: ");
            //    int gelenSayi = int.Parse(Console.ReadLine());
            //    Console.WriteLine(gelenSayi);
            //}
            //catch (FormatException exp)
            //{
            //    //Console.WriteLine("Message: Lütfen bir tam sayı giriniz.");
            //    Console.WriteLine("Message: {0}", exp.Message);
            //    //StackTrace: hatanın meydana geldiği yeri, çok ayrıntılı olarak,fiziksel dosya ve kodun satır numarasıyla birlikte getirir.
            //    //bu bilgi program içinde kullanıcıya verilmez!Ancak program tarafından hataları kaydederken (log tutarken) bu bilgileri de eklemekde fayda vardır.
            //    Console.WriteLine("Message: {0}", exp.StackTrace);
            //    Console.WriteLine("Message: {0}", exp.Source);//Hatanın tam olarak oluştuğu assembly adını verir
            //    Console.WriteLine("Message: {0}", exp.TargetSite);//Exception ı fırlatan methodu getirir
            //}
            //catch (Exception exp)
            //{
            //    //büütn hataları yakalayabilecek bir catch bloğu 
            //    //console.WriteLine("herhangi bir hata oluştu");
            //    Console.WriteLine("Message: {0}", exp.Message);
            //}

            #endregion

            #region try-catch kullanımı-4
            //string s = null;
            //Null değeri if bloğuyla basit bir şekilde kontrol edilebileceği için burdaki try-catch gereksiz bir kullanımdır
            //Geçersiz try-catch kullanımı
            //try
            //{
            //    s.ToLower();
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("Geçersiz bir string gönderdiniz.");
            //}
            //if (s != null)
            //    Console.WriteLine(s.ToLower());
            //else
            //    Console.WriteLine("geçersiz bir string gönderdiniz!");

            #endregion

            #region try-catch-finally
            //string sayi = "5";
            //try
            //{
            //    Console.WriteLine(int.Parse(sayi));
            //}
            //catch
            //{
            //    Console.WriteLine("Hata oluştu!");
            //}
            //finally
            //{   //finally bloğu try bloğu içinde exception meydana gelsede gelmesede çalışır!
            //    Console.WriteLine("Ben her halükarda çalışırım.");
            //}
            #endregion

            #region Throw Exception
            //string text = null;
            //if(text == null)
            //    throw new ArgumentNullException("text","Gelen string null olamaz!");
            //try
            //{
            //    if (text == null)
            //       throw new ArgumentNullException("text","Gelen string null olamaz!");
            //}
            //catch(ArgumentNullException ex)
            //{
            //    Console.WriteLine("ArgumentNullException: {0}", ex.Message);
            //}
            #endregion
            Console.ReadKey();
        }
    }
}
