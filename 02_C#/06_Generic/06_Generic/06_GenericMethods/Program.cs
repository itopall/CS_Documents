using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic Sınıf Kullanımı
            Sinif<int, string> sinif = new Sinif<int, string>();

            Console.WriteLine(sinif.IslemYap1(10));
            Console.WriteLine(sinif.IslemYap2("test"));
            sinif.IslemYap3(20, "test2");
            Console.WriteLine(sinif.IslemYap4(30));

            //Aşağıdaki kullanımlar derleme zamanında hata verecektir. Class seviyesinde verilen T ve K tipleri ne ise method seviyesinde de aynı tipler kullanılmalıdır.
            //sinif.IslemYap1(DateTime.Now);
            //sinif.IslemYap2(10);

            //Islemyap5 methodu class'a gönderilen T ve K tiplerini kullanmayıp kendisine özel L tipinden aldığı bilgiye göre çalışacağı için istediği tip ialabilir.
            sinif.IslemYap5<bool>(true);
            sinif.IslemYap5<DateTime>(DateTime.Now);
            sinif.IslemYap5<string>("test3");
            sinif.IslemYap5(10.2); //T'yi söylemesek de olur.
            #endregion

            #region Non Generic Sınıf Kullanımı
            //Bir methodun generic olduğunu intellisense penceresinde çıkan, methodun adından sonra yer alan küçük büyük "<>" operatörleriyle anlayabiliriz.
            NonGenericSinif nonGenericSinif = new NonGenericSinif();

            //Generic methodlar, generic parametreleri Method Çağrıları Sırasında Alırlar!
            nonGenericSinif.GenericMethod<int>(10);
            nonGenericSinif.GenericMethod("test"); //T'yi söylemesek de olur.
            nonGenericSinif.GenericMethod5<string, int, bool>("deneme", 20, true);
            nonGenericSinif.GenericMethod6<int, DateTime, char>(10, DateTime.Now, 'a', 20, DateTime.Now, 'b');

            #endregion

            Console.ReadKey();
        }
    }

    //Generic sınıf içerisinde kullanılan Generic methodlar
    class Sinif<T, K>
    {
        //Aşağıdaki methodlar, generic bir sınıfın içinde tanımlanmış ve gelen generic parametreleri kullanmışlardır.
        public T IslemYap1(T obj)
        {
            //return ""; //T'nin ne olacağı belli olmadığı için bu şekilde return edemeyiz
            //return 10;
            return obj;
        }

        public K IslemYap2(K obj)
        {
            return obj;
        }

        public void IslemYap3(T obj1, K obj2)
        {
        }

        //Class'generic olsa da non generic methodlar barındırabilir.
        public int IslemYap4(int sayi)
        {
            return 10;
        }

        //Aşağıdaki method ise generic class'dan gelen T ve K tiplerini kullanmadan kendine özel L tipinde bir generic parametre alarak çalışacak şekilde düzenlendi.
        public void IslemYap5<L>(L obj)
        {
        }
    }

    //Nongeneric sınıfların içerisinde Generic methodlar yazılabilir!
    class NonGenericSinif
    {
        public void GenericMethod<T>(T obj)
        {
        }

        //Generic methodlara kısıtlama uygulanabilir!
        public void GenericMethod2<T, K>(T obj1, K obj2) where T : IEnumerable where K : IComparable
        {
        }

        public X GenericMethod3<X>() where X : new()
        {
            return new X();
        }

        public void GenericMethod4<T>(T[] objects) where T : IComparable
        {
        }

        public void GenericMethod5<T, K, L>(T p1, K p2, L p3)
        {
        }

        public void GenericMethod6<T, K, L>(T p1, K p2, L p3, T p4, K p5, L p6)
        {
        }

        //Generic parametre ve normal parametreler aynı anda kullanılabilir.
        public void GenericMethod7<T>(T p1, int p2, string p3)
        {
        }
    }
}
