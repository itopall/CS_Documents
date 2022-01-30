using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Parametreli_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yapıcı metodumuz parametreli olduğu için parametresi newleme yaparsak hata alırız.
            //Ogrenci o = new Ogrenci() 

            //constructor parametreli old. için içerisine parametre vermemiz gerekir.
            Ogrenci o = new Ogrenci("İlker Topal", "201", "0434512412");
            //Constructor methodu içerisnde olmayan propertyleri sonradan setleme işlemi yapabiliriz.
            o.Dogumyeri = "Amasya";
            o.OgrenciId = 1;
            o.yas = 21;
            o.bilgiYazdir();
            Ogrenci o1 = new Ogrenci("Ali Ay", "201", "0434512412");
            o1.Dogumyeri = "ankara";
            o1.OgrenciId = 3;
            o1.yas = 24;
            o1.bilgiYazdir();
            Console.ReadKey();
        }
    }
}
