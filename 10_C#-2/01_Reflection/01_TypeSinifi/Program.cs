using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01_TypeSinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Type nesnesinin üretilmesi
            //typeof operatörüyle Type nesnesinin üretilmesi
            Type t = typeof(string);
            t = typeof(int);
            t = typeof(DateTime);

            //GetType() methoduyla Type nesnesinin üretilmesi
            object nesne = DateTime.Now;
            t = nesne.GetType(); //nesne'nin işaret ettiği DateTime nesnesi hakkında bilgi veren bir Type nesnesi elde edilir.
            #endregion

            #region Tip Hakkında bazı bilgilere erişmek
            Type tip = typeof(DateTime);

            Console.WriteLine("Full Name: {0}", tip.FullName);
            Console.WriteLine("Namespace: {0}", tip.Namespace);
            Console.WriteLine("Assembly: {0}", tip.Assembly.FullName);
            Console.WriteLine("Method Sayısı: {0}", tip.GetMethods().Length.ToString());
            #endregion

            #region Methodlar hakkında bilgi almak
            //String tipinin Split methodunu elde edelim

            //GetMethod("Split") dememiz yeterli olmadı! Çünkü birkaç tane Split methodu vardı, yani aşırı yüklenmiş versiyonları bulunmaktaydı.. GetMethod'un aşırı yüklenmiş versiyonunu kullanarak, parametre tiplerini de methoda gönderdik.
            MethodInfo method = typeof(string).GetMethod("Split", new Type[] { typeof(char[]) });

            MethodInfo[] methodlar = typeof(DateTime).GetMethods();
            foreach (var m in methodlar)
                Console.WriteLine(m.Name);

            Console.WriteLine("Method Adı: {0}", method.Name);
            Console.WriteLine("Dönüş Tipi: {0}", method.ReturnType.Name);
            Console.WriteLine("Abstract Mı: {0}", method.IsAbstract);
            Console.WriteLine("Generic Mi: {0}", method.IsGenericMethod);
            Console.WriteLine("Statik Mi: {0}", method.IsStatic);
            #endregion

            Console.WriteLine("###########################################################################################");

            #region Linq ile Sorgulama
            MethodInfo[] methodlar2 = typeof(string).GetMethods();

            Console.WriteLine("S ile başlayan methodlar: ");
            var list = methodlar2.Where(p => p.Name.StartsWith("S"));
            foreach (var m in list)
                Console.WriteLine(m.Name);

            Console.WriteLine("Parametre sayılarına göre methodları artan sırada listeleyelim:");
            foreach (var m in methodlar2.OrderBy(p=> p.GetParameters().Length))
                Console.WriteLine(m.Name);

            Console.WriteLine("Geriye string[] dönen kaç method var?");
            //int sayi = methodlar2.Where(p => p.ReturnType == typeof(string[])).Count();
            int sayi = methodlar2.Count(p => p.ReturnType == typeof(string[]));
            Console.WriteLine(sayi);

            Console.WriteLine("IsVirtual method var mı yok mu?");
            Console.WriteLine(methodlar2.Any(p=> p.IsVirtual));

            Console.WriteLine("Methodların hepsi non-static mi?");
            Console.WriteLine(methodlar2.Any(p => !p.IsStatic));

            Console.WriteLine("Tüm methodların ortalama parametre sayısı kaç?");
            Console.WriteLine(methodlar2.Average(p => p.GetParameters().Length));

            Console.WriteLine("Dönüş tipi int olanların parametre sayılarının toplamı kaç?");
            Console.WriteLine(methodlar2.Where(p=> p.ReturnType == typeof(int)).Sum(p => p.GetParameters().Length));
            #endregion

            Console.WriteLine("###########################################################################################");

            #region Kendi yazdığımız tiplerin detaylarına erişme
            Type typeProduct = typeof(Product);
            MethodInfo[] methodlarProduct = typeof(Product).GetMethods();
            foreach (var m in methodlarProduct)
                Console.WriteLine(m.Name);
            #endregion

            Console.ReadKey();
        }
    }
}
