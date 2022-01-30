using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ConstructorOverload
{
    class Sinif
    {
        public int sinifNo { get; set; }
        public int kapasite { get; set; }

        //constructor içerisinde gerie değer döndüren methodlar gibi kullanamayız.
        //void yazmaması default olarak void olduğu anlamına gelmez.
        //Constructor da veri tipi yoktur.
        public Sinif()
        {
            Console.WriteLine("parametresiz constructor method çalıştı!");
        }

        //Constructorlarda da normal metotlardaki gibi overload(aşırı yükleme) yapabiliriz.

        //tek parametreli constructor method tanımladık
        public Sinif(int no)
        {
            sinifNo = no;
            Console.WriteLine("tek parametreli constructor method çalıştı. Sınıf numarası: {0}" , no);
        }

        //İki parametreli constructor overload methodu tanımladık 
        public Sinif(int no,int _kapasite)
        {
            sinifNo = no;
            kapasite = _kapasite;
            Console.WriteLine("İki parametreli constructor methodu çalıştı.");
        }

        

        public void bilgiGöster()
        {
            Console.WriteLine("sınıf no: " + sinifNo + Environment.NewLine + "sınıf kapasitesi" + kapasite);
        }
    }
}
