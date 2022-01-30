using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //OrnekMethod();
            //OrnekMethod();
            //OrnekMethod();

            //method çağrılırken parametre almıyor olsa bile sonuna parantez aç kapa yapılması gerekir.
            //ParametreAlmayanGeriyeDegerDondurmeyenMethod();

            //Bir parametre alan ve geriye değer döndürmeyen methodu tetikleme yöntemi
            //BirParametreAlanGeriyeDegerDondurmeyenMethod(10);

            //İkiParametreAlanGeriyeDegerDondurmeyenMethod(10, 20);

            //UcParametreAlanGeriyeDegerDondurmeyenMethod(1, 2, "merhaba");

            //geriye değer dönen method örneği
            //int sayi = ParametreAlmayanGeriyeDegerDondurenMethod();
            //Console.WriteLine("Dönen değer:{0}", sayi);

            //string ornek = ParametreAlmayanGeriyeDegerStringDondurenMethod();
            //Console.WriteLine("Dönen değer: {0}", ornek);

            //Console.WriteLine("dönen değer: {0}", ParametreAlmayanGeriyeDegerDateTimeDondurenMethod());

            //parpametre alan ve geriyye değer dönen method çağırma yöntemi
            int deger = ParametreAlanGeriyeDegerDonenMethod(100);
            Console.WriteLine("Dönen değer: {0}", deger);
            Console.WriteLine("Dönen değer: {0}", ParametreAlanGeriyeDegerDonenMethod(100));

            Console.WriteLine("Çarpım: {0}", IkiParametreAlanGeriyeDegerDonenMethod(20,20));

            Console.WriteLine("Mesaj: {0}", UcParametreAlanGeriyeDegerDonenMethod(1000, "deneme", DateTime.Now));
            Console.ReadKey();
        }
        static void OrnekMethod()
        {
            Console.WriteLine("örnek method çalıştı");
            Console.WriteLine("örnek method çalıştı");
        }

        //static'den sonra gelen void kelimesi methodun herhangi bir değer geri döndrmediği anlamına gelir.
        //Methodun adından sonraki parantezlerin içinin boş olması methodun parametre almadığını gösterir.
        static void ParametreAlmayanGeriyeDegerDondurmeyenMethod()
        {
            Console.WriteLine("ParametreAlmayanGeriyeDegerDondurmeyenMethod çalıştı..");
        }

        //Parantezler içerisindeki değişkenler method çağırılırken girilmesi gerekne parametrelerin belirlendiği bölümdür
        //burada tanımlanan parametreler methodun içerisinde her yerde kullanılabilir.
        static void BirParametreAlanGeriyeDegerDondurmeyenMethod(int par1)
        {
            Console.WriteLine("BirParametreAlanGeriyeDegerDondurmeyenMethod, Parametre: {0}", par1);
        }

        static void IkiParametreAlanGeriyeDegerDondurmeyenMethod(int par1,int par2)
        {
            Console.WriteLine("İkiParametreAlanGeriyeDegerDondurmeyenMethod,par1: {0},par2: {1}", par1, par2);
        }

        static void UcParametreAlanGeriyeDegerDondurmeyenMethod(int par1, int par2, string par3)
        {
            Console.WriteLine("UcParametreAlanGeriyeDegerDondurmeyenMethod,par1: {0},par2: {1},par3: {2}", par1, par2,par3);
        }

        //static'den sonra gelen int değeri methodun int tipinden bir deger geri döndüreceği  anlamına gelir.Geri döndürme işlemi methodun sonund return  anahtar kelimesi ile gerçekleştirir.
        static int ParametreAlmayanGeriyeDegerDondurenMethod()
        {
            Console.WriteLine("ParametreAlmayanGeriyeDegerDondurenMethod çalıştı..");
            return 10;
        }

        static string ParametreAlmayanGeriyeDegerStringDondurenMethod()
        {
            Console.WriteLine("ParametreAlmayanGeriyeDegerStringDondurenMethod çalıştı..");
            return "test";
        }

        static DateTime ParametreAlmayanGeriyeDegerDateTimeDondurenMethod()
        {
            Console.WriteLine("ParametreAlmayanGeriyeDegerDateTimeDondurenMethod çalıştı..");
            return DateTime.Now;
        }

        // parametre alan ve geriye değer dönen method örneği
        static int ParametreAlanGeriyeDegerDonenMethod(int par1)
        {
            return par1 * 2;
        }
        static int IkiParametreAlanGeriyeDegerDonenMethod(int par1,int par2)
        {
            return par1 * par2;
        }
        static string UcParametreAlanGeriyeDegerDonenMethod(int par1, string par2,DateTime par3)
        {
            Console.WriteLine("UcParametreAlanGeriyeDegerDonenMethod, par1:{0}, par2: {1}, par3: {2}", par1, par2, par3);
            return "işlem tamamlandı";
        }
    }
}
