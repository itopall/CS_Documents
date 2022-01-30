using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Inek inek = new Inek();
            inek.BeslenmeSekli();
            inek.canlibilgisi();

            //Diğer bir alternatif
            //ICanli canli = new Inek();
            //canli.canlibilgisi();
            //IOtcul otcul = new Inek();
            //otcul.BeslenmeSekli();

            Kaplan kaplan = new Kaplan();
            kaplan.beslenmeSekli2();
            kaplan.canlibilgisi();

            //Diğer bir alternatif
            //ICanli canli = new Kaplan();
            //canli.canlibilgisi();
            //IEtcil etcil = new Kaplan();
            //etcil.BeslenmeSekli2();

            Karga karga = new Karga();
            karga.canlibilgisi();
            karga.beslenmeSekli2();
            karga.BeslenmeSekli();

            //ICanli canli = new Karga();
            //canli.canlibilgisi();
            //IEtcil etcil = new Karga();
            //etcil.beslenmeSekli2();
            //IOtcul otcul = new Karga();
            //otcul.BeslenmeSekli();

            Aslan aslan  = new Aslan();
            aslan.beslenmeSekli2();
            aslan.canlibilgisi();

            Bilgisayar pc = new Bilgisayar();
            pc.cansizBilgisi();
            pc.bilgiler();


            Console.ReadKey();
        }
    }
}
