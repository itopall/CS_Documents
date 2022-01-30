using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegate
{
    //1) Tmele .Net tiplerinden biridir, referans türlüdür.
    //2) methodların çalıştıkları bellek alanlarının başlangıç adreslerini saklayabilirler.Diğer bibr değişle methodları adreslerini saklma tekniğiyle işaret edebilirler.
    //3)Birden fazla method adresi bir delege nesnesine bağlanabilir.
    //4)Yoğun olarak kullanım noktaları;
          //1) Event bazlı programlama
          //2) LINQ
          //3) Asenkron programlama
    //5) Bir delege tanımlanırken, adreslerini sakyabileceği method imzasıyla birlikte tanımlanır.

    //Delegenin 2 amacı
    //1) method adreslerini daha sonra kullanmak üzere saklamak(Event'ler bu mantıkla oluşur)
    //Bir methoda parametre olarak başka bşr methodu adresiyle geçmek(LINq  ve Entity framework'de yoğun şekilde kullanılır.)


    //Temesilci adında bir tip tanımladık. Bu tipin nesneleri, çağrılma zamanında geriye bir şey dönmeyen ve parametre almayan tüm methodları işaret edebilir.
    delegate void Temsilci();
    class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method1 methodu çağrıldı...");
        }

        static void Method2()
        {
            Console.WriteLine("Method2 methodu çağrıldı...");
        }
        static void Main(string[] args)
        {
            //Method1 methodu çağrılmadı! Dolayısıyla bu bir method çağrısı olmadığından dolayı, parantez açıp kapatılmaz.
            //Temsilci t = new Temsilci(Method1);
            Temsilci t = Method1;//yukarıdakiyle bu yazım bire bir aynıdır.

            //Delegate'e yeni bir method daha ekledik
            t += Method2;

            //Aynı methodu ikinci kez ekleyebiliriz.
            t += Method2;

            //t'nin işaret ettiği method listesindeki (delege nesnesi) tüm methodlar bağlanma sırasıyla çağrılır.
            t.Invoke();


            Console.ReadKey();
        }

        
    }
}
