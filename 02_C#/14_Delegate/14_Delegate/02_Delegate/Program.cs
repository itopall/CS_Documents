using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegate
{
    //string tipinde Parametre alan ancak herhangi bir tip return etmeyen methodlar eklenebilir.
    delegate void Test(string a);

    //int tipinde iki parametre alan ve geriye int tipinde değer dönen methodlar eklenebilir
    delegate int IslemHandler(int a, int b);
    class Program
    {
        //Test delegate'inin imzasına uyan methodlar
        static void MesajVer(string message)
        {
            Console.WriteLine(message);
        }

        static void MesajVer2(string message)
        {
            Console.WriteLine("MesajVer2 çalıştı: " + message);
        }

        //IslemHandler delegate'inin imzasına uyan methodlar.
        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        static void Main(string[] args)
        {
            #region Parametre alan Geri değer dönmeyen Delegate
            //Test t = new Test(MesajVer);
            Test t = MesajVer;
            t += MesajVer;
            t += MesajVer2;
            //t.Invoke("Merhaba");
            t("Merhaba");//Yukarıdakiyle bu yazım bire bir aynı.
            #endregion

            #region Parametre Alan geriye değr Dönen delegate
            //Not: Birden fazla sonuç dönen method invoke edildiğinde son invoke edilenin sonucu alınır!

            //IslemHandler handler = new IslemHandler(Topla);
            IslemHandler handler = Topla;//Yukarıdakiyle aynıdır.

            //Non-static bir methodu da delegate'e ekleyebiliriz.
            //Program p = new Program();
            //handler += p.Cikar;
            handler += new Program().Cikar;//Yukarıdakiyle aynı işlemi yapar.

            int sonuc = handler.Invoke(20, 10);
            Console.WriteLine(sonuc);
            #endregion


            Console.ReadKey();
        }
    }
}
