using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GenericExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 10;
            sayi.Kareal();
            sayi.HerYerdeCikacakMethod();
            sayi.SadeceStruct();//Generic tipi belirtmesek de olur

            Structtest st = new Structtest();
            st.HerYerdeCikacakMethod();
            st.SadeceStruct();

            Urun urun = new Urun();
            urun.HerYerdeCikacakMethod();
            urun.SadeceUrun();



            Console.ReadKey();
        }
    }
    public class Urun
    {

    }
    struct Structtest
    {

    }
}
