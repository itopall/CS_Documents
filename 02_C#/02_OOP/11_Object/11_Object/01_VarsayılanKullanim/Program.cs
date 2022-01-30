using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_VarsayılanKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ToString
            Program p = new Program();
            Console.WriteLine(p.ToString());

            //int'e özel override edilmiş versiyon
            int sayi = 0;
            sayi.ToString();

            //DateTime'a özel override edilmiş versiyon
            DateTime tarih = DateTime.Now;
            tarih.ToString();
            #endregion

            #region Equals -Deger Turlu
            int s1 = 10;
            int s2 = 10;

            Console.WriteLine(s1.Equals(s2) ? "Eşit":"Eşit Değildir.");
            #endregion

            #region Equals - Referans Turlu
            Ogrenci o1 = new Ogrenci(1000);
            Ogrenci o2 = new Ogrenci(1000);

            o1 = o2;
            Console.WriteLine(o1.Equals(o2) ?"Eşit":"Eşit Değildir" );
            #endregion

            #region GetHashCode - Deger Turlu
            int a = 10;
            double b = 10.2;
            int c = 10;
            double d = 10.2;

            Console.WriteLine("a: {0}", a.GetHashCode());
            Console.WriteLine("b: {0}", b.GetHashCode());
            Console.WriteLine("c: {0}", c.GetHashCode());
            Console.WriteLine("d: {0}", d.GetHashCode());
            #endregion

            #region GetHashCode - Referans Turlusu
            Ogrenci ogr1 = new Ogrenci(2000);
            Ogrenci ogr2 = new Ogrenci(2000);

            Console.WriteLine("ogr1: {0}", ogr1.GetHashCode());
            Console.WriteLine("ogr2: {0}", ogr2.GetHashCode());

            ogr1 = ogr2;
            Console.WriteLine("ogr1: {0}", ogr1.GetHashCode());
            Console.WriteLine("ogr2: {0}", ogr2.GetHashCode());
            #endregion

            #region GetHashCode - string
            string str1 = "test";
            string str2 = "test";

            Console.WriteLine("str1: {0}",str1.GetHashCode());
            Console.WriteLine("str2: {0}",str2.GetHashCode());

            //İki string'in case sensitive karşılaştırılabilmesi için her ikiside büyük ya da her ikisi de küçük yapılabilir.
            
            #endregion


            Console.ReadKey();
        }
    }
    class Ogrenci
    {
        public int No { get; set; }

        public Ogrenci(int no)
        {
            No = no;
        }
    }
}
