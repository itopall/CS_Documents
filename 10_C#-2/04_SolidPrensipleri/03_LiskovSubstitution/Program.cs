using _03_LiskovSubstitution.DogruOrnek;
using _03_LiskovSubstitution.KotuOrnek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LiskovSubstitution
{
    //(L)iskov's Substitution Principle
    //Türeyen sınıflar base sınıflardan gelen methodların tamamını kullanmalıdırlar.
    class Program
    {
        static void Main(string[] args)
        {
            //abstract tipler soyut sınıflar olduğu için nesneleri üretilemez sadece base sınıf olarak kullanılırlar.
            //BasePrinter basePrinter = new BasePrinter();

            #region Kotu Kullanım
            //Hem yazıcı hem de tarayı özelliğine sahip bir canon modeli
            CanonPrinter canonPrinter = new CanonPrinter();
            canonPrinter.Print("Cv");
            canonPrinter.Scan("İzin Formu");

            //Sadece yazıcı özelliğine sahip bir Hp yazıcı modeli.
            HpPrinter hpPrinter = new HpPrinter();
            hpPrinter.Print("Dilekçe");
            //hpPrinter.Scan("İzin Formu");

            //Hem yazıcı hem de tarayı özelliğine sahip bir xerox modeli
            XeroxPrinter xeroxPrinter = new XeroxPrinter();
            xeroxPrinter.Print("Cv");
            xeroxPrinter.Scan("İzin Formu");
            #endregion

            #region Dogru Kullanım
            //Hem yazıcı hem de tarayı özelliğine sahip bir canon modeli
            CanonPrinterNew canonPrinterNew = new CanonPrinterNew();
            canonPrinterNew.Print("Cv");
            canonPrinterNew.Scan("İzin Formu"); //IScan interface'i implement edildiği için bu method kullanılabilir.

            //Sadece yazıcı özelliğine sahip bir Hp yazıcı modeli.
            HpPrinterNew hpPrinterNew = new HpPrinterNew();
            hpPrinterNew.Print("Dilekçe");
            //hpPrinterNew.Scan("İzin Formu"); //IScan interface'i implement edilmediği için bu method kullanılamaz!

            //Hem yazıcı hem de tarayı özelliğine sahip bir xerox modeli
            XeroxPrinterNew xeroxPrinterNew = new XeroxPrinterNew();
            xeroxPrinterNew.Print("Cv");
            xeroxPrinterNew.Scan("İzin Formu"); //IScan interface'i implement edildiği için bu method kullanılabilir.
            #endregion

            Console.ReadKey();
        }
    }
}
