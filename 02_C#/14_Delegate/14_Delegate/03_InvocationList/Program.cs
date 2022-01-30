using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InvocationList
{
    class Program
    {
        delegate int AritmetikHandler(int x, int y);
        static void Main(string[] args)
        {
            AritmetikHandler handler = Aritmetik.Topla;
            handler += Aritmetik.Cikar;
            handler += Aritmetik.Carp;
            handler += Aritmetik.Bol;

            //Şuanda delegate'i invoke edersek geriye son bağlanan methodun sonucu döner
            int sonuc = handler(20, 10);
            Console.WriteLine(sonuc);

            //hedef: handler'ın işaret ettiği 4 methodun sonuçlarını ayrı ayrı elde etmek.
            //getInvacationList() methodu, listedeki methodlara tek tek erişmemizi sağlayan Delegate[] döner.
            //Gelen bu dizi içerisindeki her bir Delegate nesnesi bir methodu işaret eder!
            //Örneğin: methodlar[0]'daki temsilci Invoke() edilirse, yalnızca Topla methodu çalıştırılır ve yalnızca Topla methodunun dönüş değeri elde edilir.
            Delegate[] methodlar = handler.GetInvocationList();

            //delegate dizisindeki elemnaları aşağıdaki şekilde çağırabiliriz.
            Console.WriteLine(methodlar[0].DynamicInvoke(20, 10));
            Console.WriteLine(methodlar[1].DynamicInvoke(20, 10));

            //getInvocationList()'den alınan Delegate nesneleri AritmetikHandler'a cast edilebilir.
            foreach (Delegate method in methodlar)
                Console.WriteLine(method.DynamicInvoke(20, 10));

            foreach (AritmetikHandler method in methodlar)
                Console.WriteLine(method.DynamicInvoke(20,10));
          


            Console.ReadKey();
        }
    }
}
