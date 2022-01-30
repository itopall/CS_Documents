using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _04_delegateHakkindaBilgiAlmak
{
    class Program
    {
        delegate void FiyatHandler(double oran);
        static void Main(string[] args)
        {
            #region Ornek-1
            //Methodu gelegeye bağlarken hangi Urun nesnesi için çalışacağını söylemeliyiz.Çünkü ZamYap methodu nonstatic bir method olup bir Urun nesnesi için çalışır ve bir Urun nesnesine zam yapımasını sağlar.
            //Aşağıda urun2 nesnesi üreterek aynı aynı 2 farklı ürüne zam yapılmasını sağladık.

            Urun urun = new Urun(1,"ThinkPad",10000);
            Urun urun2 = new Urun(2, "Klavye", 100);

            FiyatHandler handler1 = urun.ZamYap;
            handler1 += urun2.ZamYap;
            handler1(0.18);
            Console.WriteLine(urun.Fiyat);
            Console.WriteLine(urun2.Fiyat);
            #endregion

            #region Ornek-2
            FiyatHandler handler2 = new Urun(3, "Mouse", 100).ZamYap;
            handler2(0.20);
            handler2(0.20);
            handler2(0.20);
            
            //FiyatHandler delegesi'nin çalıştıracağı nonstatic method hangi nesne için çalışıyorsa, o nesneyi elde edebiliriz.
            Urun urn = (Urun)handler2.Target;
            Console.WriteLine($"Ürünün adı: {urn.Ad} - Son fiyatı: {urn.Fiyat}");

            //MethodInfo nesnesi, bir method hakkında bilgi veerir.
            //Benzer şekilde property hakkında bilgi veren PropertyInfo
            //Benzer şekilde constructor hakkında bilgi veren ConstructorInfo
            //Bir methodun parametresi hakkında bilgi veren ParametreInfo,
            //Bir field hakkında bilgii veren FieldInfı vb. class'lar vardır.
            MethodInfo mi = handler2.Method;
            Console.WriteLine($"Method adı: {mi.Name}");
            Console.WriteLine($"Parametre sayısı: {mi.GetParameters().Length}");
            Console.WriteLine($"Abstract mı: {mi.IsAbstract}");
            #endregion

            #region Static method
            handler2 += Urun.Test;
            Console.WriteLine(handler2.Target == null ? "Bağlanan son method static'tir" : "Bağlanan son method non-static'dir") ;
            #endregion

            Console.ReadKey();
        }
    }
}
