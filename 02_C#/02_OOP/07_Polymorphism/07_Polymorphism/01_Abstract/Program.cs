using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //polymorphism(çok biçimlilik), nesnelerin,methodların, propertylerin farklı biçim özllik kazanmasına yani çok biçimli hal alabilmesine denir.

            //Base classlarda ortak propertyler ve ortak methodlar, devired classlarda farklı biçim/işlev kazanmış olması polymorphism olarak adlandırılır.

            //Abstract classlar soyut sınıflar olarak geçiyor. Yapıyı olustururken, abstract classlarımız her zaman base class olacak şekilde oluşturmak ve sonrasınd aiçerisindeki metotları ve özellikleri derived classlar içerisnde override(ezme işlemi/üzerine yazma)ederek derived classlarda bu methodlar ve özellikler farklı bir biçim almış oluyor. Ve bu metotlar kendi classlarında kullanılıyor. 

            //Aynı tipli değişkenin(Canlı) aynı methodunu çağırdığımızda farklı bir işlem yaptırmış olduk.

            //Abstract classlardan nesne türetilemez.
            //Canlı c = new Canlı();

            //Yukarıdaki hatayı gidermek için aşağıdaki işlemi yapabiliriz.
            Canlı c = new Balık();
            Console.WriteLine("Canlı sınıfını referans alarak, Balık sınıfından nesne türetme");
            //Canlı sınıfını referans alarak , Balık sınıfından nesne türettiğimizde HareketEt() metodu içi dolu olan (Balık classındaki) abstract metodu çağırır.
            c.HareketEt();


            Balık b = new Balık();
            b.HareketEt();
            b.Add2();

            Insan i = new Insan();
            i.HareketEt();

            Kus k = new Kus();
            k.HareketEt();

            Yilan y = new Yilan();
            //Add2() methodu Canlı class'ında ortak olduğu için ve override edilmediği için Canlı slass'ındaki işlemini ge
            y.HareketEt();

            Console.ReadKey();
        }
    }
}
