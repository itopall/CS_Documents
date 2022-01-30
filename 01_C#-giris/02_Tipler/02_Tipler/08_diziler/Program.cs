using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dizi tanımlama
            // Aşağıdaki töntemlerden herhangi birini kullanarak dizi tanımlaması gerçekleştirebiliriz.
            int[] n1 = new int[4] { 2, 4, 6, 8 };
            int[] n2 = new int[] { 2, 4, 6, 8, 10 };
            int[] n3 = { 2, 4, 6, 8 };
            int[] n4 = new int[4];

            string[] s1 = new string[4] { "s", "a", "b", "c" };
            string[] s2 = new string[] { "s", "a", "b", "c" };
            string[] s3 = { "b", "c", "d", "w" };
            string[] s4 = new string[4];

            #endregion

            #region Dizinin içerisindeki bir elemana erişme
            //Dizinin içerisindeki bir değere erişmek için dizi adı yazılır köşeli parantez ile index numarası verilir.
            Console.WriteLine(n1[2]);
            int dizininIkincielemanı = n1[2];
            Console.WriteLine(dizininIkincielemanı);


            n1[2] = 50;//Dizinin 2. index'indeki değeri 50 olarak değiştirdik
            Console.WriteLine(n1[2]);
            #endregion

            #region sum
            int ToplamDeger = n1.Sum();
            Console.WriteLine("toplam deger: {0}", ToplamDeger);
            #endregion

            #region max
            int max = n1.Max();
            Console.WriteLine("en büyük deger: {0}", max);
            #endregion

            #region min
            int min = n1.Min();
            Console.WriteLine("en küçük deger: {0}", min);
            #endregion

            #region SequenceEqual
            // iki dizinin aynı olup olmadığını kontrol eder. Method true dönerse aynıdır false dönerse aynı değildir
            bool sonuc = n1.SequenceEqual(n3);
            Console.WriteLine("iki dizi aynı mı?: {0}", sonuc);
            #endregion

            #region Contains
            // bir değerin dizi içerisinde olup olmadığını aratmak istersek Contains methodunu kullanırız.Arattığımız değer dizinin içinde varsa True döner yoksa False döner
            bool sonuc1 = n1.Contains(2);
            Console.WriteLine("değer dizinin içerisinde var mı?: {0}", sonuc1);
            #endregion

            #region Concat
            //iki diziyi birleştirmek için kullanılır.
            int[] yeniDizi = n1.Concat(n2).ToArray();
            Console.WriteLine("Yeni dizinin uzunluğu: {0}", yeniDizi.Length);
            #endregion

            //array sınıfı üzerinden yapılabilecek bazı işlemler
            #region Reverse
            //reverse dizi elemanlarını ters çevirir.(ilk eleman sona son eleman başa gelecek şekilde
            Array.Reverse(n1);
            //1. indexten itibaren başlayarak 3 karakteri ters çevirir
            Array.Reverse(n1, 1, 3);
            #endregion

            #region Sort
            // Dizinin elemanlarını küçükten büyüğe doğru (0-9 veya a-z) sıralar.Methodun 2 farklı kullanım şekli var.parntez içine sadece dizi adı yazılırsa tüm diziyi sıralar.İstenirse başlangıç elemanlarının numarasını ve sıralanacak eleman sayısı verilerek dizinin belli bir bölümüde sıralanabilir

            Array.Sort(s1);
            //2. değerden itibaren sıradaki 2 değer sıralanacak.
            Array.Sort(s1, 2, 2);
            #endregion

            #region IndexOf
            //Dizinin elemanları aramasında istenilen değerin aranmasını ve bulunduğunda index numarasını geri dönmesini sağlar
            int index = Array.IndexOf(s1, "s");
            Console.WriteLine("IndexOf degeri: {0}", index);

            //1. index'ten başlayarak 3 index sonrasına kadar arama işlemi yapar.
            int index2 = Array.IndexOf(s1, "s", 1, 3);
            Console.WriteLine("IndexOf değeri: {0}", index2);
            #endregion

            #region Multi diziler
            int[,] array2D = new int[3, 2] { { 2, 1 }, { 3, 2 }, { 5, 6 } };
            int[,] array2Da = new int[,] { { 2, 1 }, { 3, 2 }, { 5, 6 }, { 7, 8 } };
            string[,] array2Db = new string[,] { { "bir" }, { "iki" }, { "üç" }, { "dört" }, { "beş" } };
            string[,] array2Dc = new string[,]
            {
                {"bir","iki","üç"  },
                {"dört","beş","altı" },
                {"yedi","sekiz","dokuz" },
                {"on","onbir","oniki" }
            };

            int[,,]  array3Da = new int[2, 2, 3]
            {
                { {1,2,3 }, {4,5,6 } },
                { {7,8,9 }, {10,11,12 } }
            };

            Console.WriteLine(array2D.GetLength(0));
            Console.WriteLine(array2D.GetLength(1));


            Console.WriteLine(array2D[0, 1]);
            array2D[0, 1] = 100;
            Console.WriteLine(array2D[0, 1]);
            Console.WriteLine(array3Da[0,1,2]);
            Console.Write("Sum: " + array3Da.Cast<int>().Sum());
            #endregion

            Console.ReadKey();
        }
    }
}
