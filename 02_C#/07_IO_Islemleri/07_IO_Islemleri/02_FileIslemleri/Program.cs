using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FileIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yeni Bir dosya oluşturma
            //FileStream fs = File.Create(@"C:\_Kaynak\YeniDosyaTest.txt");
            //fs.Close();

            //Dosya kopyalama
            //File.Copy(@"C:\_Kaynak\YeniDosyaTest.txt", @"C:\_Hedef\YeniDosyaTest.txt");

            //Dosyayı adını değiştirerek kopyalama
            //File.Copy(@"C:\_Kaynak\YeniDosyaTest.txt", @"C:\_Hedef\YeniDosyaTest2.txt");

            //Dosya taşıma 
            //File.Move(@"C:\_Kaynak\YeniDosyaTest.txt", @"C:\_Hedef\YeniDosyaTest3.txt");

            //Dosya var mı yok mu kontrol etme
            bool isExist = File.Exists(@"C:\_Hedef\SilinecekDosyaTest.txt");
            if (isExist)
            {
                File.Delete(@"C:\_Hedef\SilinecekDosyaTest.txt");
                
            }
            else
            {
                FileStream fs2 = File.Create(@"C:\_Hedef\SilinecekDosyaTest.txt");
                fs2.Close();
            }
            //Bir Dosyaya Text yazma (Varolan satırları silmeden dosyanın sonuna ekleme yapar)
            //File.AppendAllText(@"C:\_Hedef\YeniDosyaTest.txt","Yazılım sınıfı IO örnekleri\r\n");

            //Dosyaya metin yazma(Varolan satırları silip sadece yeni gönderdiğimiz metni yazar)
            //File.WriteAllText(@"C:\_Hedef\YeniDosyaTest.txt", "Yazılım sınıfı IO örnekleri\r\n");

            //Bir text dosyasının içeriğini text olarak okuma
            //string text = File.ReadAllText(@"C:\_Hedef\YeniDosyaTest.txt",Encoding.UTF8);

            //Bir text dosyasının içeriğini satır olarak okuma
            //string[] satirlar = File.ReadAllLines(@"C:\_Hedef\YeniDosyaTest.txt", Encoding.UTF8);

            //Bir dosyanın niteliklerini belirtme
            //File.SetAttributes(@"C:\_Hedef\Attribute.txt", FileAttributes.Hidden | FileAttributes.ReadOnly);

            //Dosya Birleştirme
            string file1 = File.ReadAllText(@"C:\_Hedef\YeniDosyaTest.txt", Encoding.UTF8);
            File.AppendAllText(@"C:\_Hedef\YeniDosyaTest3.txt", file1);

            //FileInfo sınıfı
            FileInfo fi = new FileInfo(@"C:\_Hedef\FileInfoTest.txt");
            if (fi.Exists)
            {
                //Dosya varsa sil
                fi.Delete();
            }
            //Dosya oluştur
            fi.Create();
            Console.WriteLine("Dosya Oluşturuldu...");
            Console.WriteLine("Oluşturulma Tarihi: {0}",fi.CreationTime);
            Console.WriteLine("Son oluşum Tarihi: {0}",fi.LastAccessTime);
            Console.WriteLine("Son değiştirilme Tarihi: {0}",fi.LastWriteTime);
            Console.WriteLine("Bulunduğu dizinin adı: {0}",fi.DirectoryName);
            Console.WriteLine("Dosyanın adı: {0}",fi.Name);
            Console.WriteLine("Dosyanın tam adı: {0}",fi.FullName);
            Console.WriteLine("Dosyanın Uzantısı: {0}",fi.Extension);

            Console.ReadKey();
        }
    }
}
