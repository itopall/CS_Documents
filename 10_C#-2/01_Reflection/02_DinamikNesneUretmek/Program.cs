using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace _02_DinamikNesneUretmek
{
    //Reflection, çalışma zamanında tiplere ve üyelerine erişmemizii bu üyeleri dinamik olarak kullanmamızı sağlar.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üretmek istediğiniz tipin adını giriniz: ");
            string tipAdi = Console.ReadLine();
            
            Console.WriteLine("Değer giriniz: ");
            object deger = Console.ReadLine();

            //Kullanıcının örneklemek istediği tip hakkında bilgi veren bir Type nesnesi elde edilir.
            //string tipAdi'ndan Type nesnesi elde etmemizi sağlayan Type.GetType methodunu kullanabiliriz.
            Type orneklenmekIstenentip = Type.GetType(tipAdi);

            object nesne = Activator.CreateInstance(orneklenmekIstenentip);
            nesne = deger;

            Console.WriteLine("Nesne oluşturuldu, değeri: " + nesne);

            Console.ReadKey();
        }
    }
}
