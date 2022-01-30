using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FolderIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //C sürücüsü altındaki klasörleri listeleme
            string[] klasorler = Directory.GetDirectories("C:\\");//@"C:\" bu şekilde de yazılabilir
            klasorler = Directory.GetDirectories("C:\\Program Files");

            //Bİr klasör içerisindeki dosyaları listeleme
            string[] dosyalar = Directory.GetFiles("C:\\");
            foreach (string dosya in dosyalar)
                Console.WriteLine(dosya);

            //Sürücü listesini alma
            string[] suruculer = Directory.GetLogicalDrives();

            //Yeni bir klasör oluşturma
            //Directory.CreateDirectory(@"C:_Kaynak\YeniKlasorDeneme");

            //Bir klasörü taşıma
            //Directory.Move(@"C:\_Kaynak\YeniKlasorDeneme", @"C:\_Hedef\YeniKlasorDeneme");

            //Klasö var mı yok mu kontrol etme
            //bool isExist = Directory.Exists(@"C:\_Hedef\SilinecekKlasor");
            //if (isExist)
            //{
            //    //Klasör varsa sil
            //    Directory.Delete(@"C:\_Hedef\SilinecekKlasor");
            //}
            //else
            //{
            //    //Klasör yoksa oluştur
            //    Directory.CreateDirectory(@"C:\_Hedef\SilinecekKlasor");
            //}

            //Klasörün oluşturulma tarihi
            DateTime ct = Directory.GetCreationTime(@"C:\_Hedef\YeniKlasorDeneme");


            //Klasörün son erişilme tarihi
            DateTime lat = Directory.GetLastAccessTime(@"C:\_Hedef\YeniKlasorDeneme");

            //Klasörün üst klasörünü elde etme
            DirectoryInfo parent = Directory.GetParent(@"C:\_Hedef\YeniKlasorDeneme");

            //Klasörün oluşturulma tarihini set etme
            Directory.SetCreationTime(@"C:\_Hedef\YeniKlasorDeneme",DateTime.Now.AddDays(10));
            DateTime ct2 = Directory.GetCreationTime(@"C:\_Hedef\YeniKlasorDeneme");
            Console.WriteLine(ct2);

            //DrectoryInfo kullanımı
            DirectoryInfo di = new DirectoryInfo(@"C:\_Hedef\DirectoryInfoTest");
            if (di.Exists)
            {
                di.Delete();
                Console.WriteLine("Klasör silindi.");
            }

            //Yeni klasör oluşturma
            di.Create();
            Console.WriteLine("Klasör oluşturuldu.");
            Console.WriteLine("Oluşturulma Tarihi: {0}",di.CreationTime);
            Console.WriteLine("Bulunduğu Dizinin Adı: {0}",di.Parent);
            Console.WriteLine("Klasörün Adı: {0}",di.Name);
            Console.WriteLine("Klasörün tam Adı: {0}",di.FullName);
            Console.WriteLine("Son erişim tarihi: {0}",di.LastAccessTime);
            Console.WriteLine("Son değiştirilme tarihi: {0}",di.LastWriteTime);



            Console.ReadKey();
        }
    }
}
