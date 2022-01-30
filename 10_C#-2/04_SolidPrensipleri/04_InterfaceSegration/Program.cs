using _04_InterfaceSegration.DogruOrnek;
using _04_InterfaceSegration.KotuOrnek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InterfaceSegration
{
    //(I)nterface Segragation Principle
    //Interface'lerin birbirinden ayrılmasını söyler.
    class Program
    {
        static void Main(string[] args)
        {
            #region Kotu Örnek
            Bmw bmw = new Bmw();
            bmw.Calistir();
            bmw.Durdur();
            bmw.RadyoyuAc();
            bmw.KlimayiAc();

            Sahin sahin = new Sahin();
            sahin.Calistir();
            sahin.Durdur();
            sahin.RadyoyuAc();
            //sahin.KlimayiAc(); //Sahin marka araçda klima olmamalı! Ancak IArac gibi genel bir interface tanımladığımız için KlimayiAc methodunu kaldıramıyoruz.
            #endregion

            #region Doğru Örnek
            BmwNew bmwNew = new BmwNew();
            bmwNew.Calistir();
            bmwNew.Durdur();
            bmwNew.RadyoyuAc(); //IRadyoluArac interface'ini implement ettiği için RadyoyuAc methoduna erişilebiliyor.
            bmwNew.KlimayiAc(); //IKlimayiAc interface'ini implement ettiği için KlimayiAc methoduna erişilebiliyor.

            SahinNew sahinNew = new SahinNew();
            sahinNew.Calistir();
            sahinNew.Durdur();
            sahinNew.RadyoyuAc(); //IRadyoluArac interface'ini implement ettiği için RadyoyuAc methoduna erişilebiliyor.
            //sahinNew.KlimayiAc(); //IKlimaliArac interface'ini implement etmediği için bu özellik kullanılamaz!

            PirpirNew pirpirNew = new PirpirNew();
            pirpirNew.Calistir(); 
            pirpirNew.Durdur();
            //pirpirNew.RadyoyuAc(); //IRadyoluArac interface'ini implement etmediği için bu özellik kullanılamaz!
            //sahinNew.KlimayiAc(); //IKlimaliArac interface'ini implement etmediği için bu özellik kullanılamaz!
            #endregion

            Console.ReadKey();
        }
    }
}
