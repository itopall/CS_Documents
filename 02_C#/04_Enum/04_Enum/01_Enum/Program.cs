using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enum kullanımı
            //enum'ın string değerini kullanarak atama yapmak
            Sehirler s1 = Sehirler.Izmir;
            Console.WriteLine(s1);

            //enum'ın rakamsal karşılığını kullanarak atama yapma
            Sehirler s2 = (Sehirler)6;
            Console.WriteLine(s2);

            //Enum değeri ile rakamsal değere erişmek
            Console.WriteLine((int)s1);
            Console.WriteLine(Convert.ToInt32(s1));

            Console.WriteLine("Kullanıcı Tipi: {0}",KullaniciTipi.Admin);
            Console.WriteLine("Kullanıcı Tipi: {0}",(int)KullaniciTipi.Admin);
            #endregion

            #region Enum olmasaydı
            //Rakamsal karşılıklar tutulamıyor
            string tip0 = "Admin"; 
            string tip1 = "SuperUser"; 
            string tip2 = "User";

            //Rakamsal karşılıklar tutulmadığı için manuel olarak yazılıyor. Tip değeri birden fazla yerde kullanıldığında bu durum mauel olarak değer girilmesine ve hataya müsait bir zemin oluşmasına sebep olacaktır. Aynı zamanda da değişikli gerektiğinde pek çok yerde değişiklik yapmak gerekecektir.
            Console.WriteLine("kullanıcı tipi: {0} değeri: {1}", tip0, 0);
            Console.WriteLine("kullanıcı tipi: {0} değeri: {1}", tip1, 1);
            Console.WriteLine("kullanıcı tipi: {0} değeri: {1}", tip2, 2);
            #endregion

            #region Enum Olmasaydı v2
            //V1'deki belirtilen durumlar burada da aynen geçerlidir
            string[] tipler = new string[] { "Admin", "SuperUser", "User" };

            Console.WriteLine("kullanıcı tipi: {0} değeri: {1}", tipler[0], 0);
            Console.WriteLine("kullanıcı tipi: {0} değeri: {1}", tipler[1], 1);
            Console.WriteLine("kullanıcı tipi: {0} değeri: {1}", tipler[2], 2);
            #endregion

            #region Thanks Enum
            KullaniciTipi admin = KullaniciTipi.Admin;
            KullaniciTipi superUser = KullaniciTipi.SuperUser;
            KullaniciTipi user = KullaniciTipi.User;

            Console.WriteLine("kullanıcı tipi: {0} değeri: {1}", admin,(int)admin);
            Console.WriteLine("kullanıcı tipi: {0} değeri: {1}", superUser, (int)superUser);
            Console.WriteLine("kullanıcı tipi: {0} değeri: {1}", user, (int)user);
            #endregion

            #region string[] olarak enum'daki sabitleri almak
            string[] sehirler = Enum.GetNames(typeof(Sehirler));
            foreach (string sehir in sehirler)
                Console.WriteLine(sehir);

            #endregion

            #region int[] olarak enum'daki sabitleri almak
            int[] degerler = (int[])Enum.GetValues(typeof(Sehirler));
            foreach (int deger in degerler)
                Console.WriteLine(deger);

            #endregion

            #region Bir enum'ın kullandığı tipi elde etmek
            Type tipBilgisi = Enum.GetUnderlyingType(typeof(Sehirler));
            Console.WriteLine(tipBilgisi.FullName);
            #endregion

            #region Enum içerisinde bir değerin bulunup bulunmadığı kontrol etmek
            bool sonuc = Enum.IsDefined(typeof(Sehirler),34);
            Console.WriteLine(sonuc);

            bool sonuc2 = Enum.IsDefined(typeof(Sehirler), "Ankara");
            Console.WriteLine(sonuc2);
            #endregion

            #region stirng olarak gelen bilgiyi Sehirler enum'ı haline getirmek
            //Enum.Parse() herhangi bir enum tipi için kullanılabilir. string olarak gelen sabiti, ilgili tipine dönüştürmek için kullanılır. Parse() methodu object olduğundan gelen değerin Sehirler olacağını bilinçli olarak söyledik(cast ederek)

            Console.Write("Şehir giriniz: ");
            string gelenDeger = Console.ReadLine();
            Sehirler sehirler2 = (Sehirler)Enum.Parse(typeof(Sehirler), gelenDeger);
            Console.WriteLine("Plaka kodu: {0} , Adı: {1}", (int)sehirler2, sehirler2);
            #endregion

            #region ConsoleColor Enum'ı kullanımı
            Console.Write("BackGroundColor Giriniz: ");
            string backColor = Console.ReadLine();

            Console.Write("ForegroundColor giriniz: ");
            string foreColor = Console.ReadLine();

            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), backColor);
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), foreColor);
            Console.Clear();
            Console.WriteLine("Renkler ayarlandı...");
            #endregion

            Console.ReadKey();
        }
    }
    enum Sehirler : int
    {
        Istanbul = 34,
        Izmir = 35,
        Ankara = 06

    }
    enum KullaniciTipi : int
    {
        Admin,
        SuperUser,
        User
    }
}
