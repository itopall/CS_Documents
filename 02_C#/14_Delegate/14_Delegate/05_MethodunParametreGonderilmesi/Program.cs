using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MethodunParametreGonderilmesi
{
    delegate void IslemHandler();
    delegate void ConsoleMessageHandler(string message);

    class Program
    {
        static void Main(string[] args)
        {
            #region IslemHandler kullanımı
            IslemHandler handler = new IslemHandler(Islem1);
            IslemTetikle(handler);
            #endregion

            #region ConsoleMessageHandlerKullanımı
            ConsoleMessageHandler handler2 = new ConsoleMessageHandler(UyariMesajı);
            //handler2.Invoke("Girdiğiniz bilgileri kontrol ediniz!");
            ConsoleMesajTetikle(handler2, "Girdiğiniz bilgileri kontrol ediniz.");
            #endregion

            Console.ReadKey();
        }
        //Bu method IslemHandler temsilcisi tarafından işaret edilebilir
        static void Islem1()
        {
            Console.WriteLine("Islem1 çağrıldı");
        }

        static void IslemTetikle(IslemHandler handler)
        {
            //Gelen methodun adını aldık
            Console.WriteLine($"{handler.Method.Name} methodu az sonra çalışacak!");

            //Helen methodu tetikledik
            handler.Invoke();//handler(); şeklindede yazılabliir.
            Console.WriteLine("Method çağrısı tamamlandı.");
        }

        //Bu method ConsoleMesajHandler temsilcisi tarafından işaret edilebilir.
        static void UyariMesajı(string message)
        {
            Console.WriteLine("Uyarı: " + message);
        }
        static void ConsoleMesajTetikle(ConsoleMessageHandler h, string parametre)
        {
            h.Invoke(parametre);
            //h.Invoke("Girdiğiniz bilgileri kontrol ediniz.");
        }
    }
}
