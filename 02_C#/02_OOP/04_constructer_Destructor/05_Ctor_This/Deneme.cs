using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Ctor_This
{
    class Deneme
    {
        //ctor iki kere taba basınca Constructor oto. oluşur.
        public Deneme()
        {
            Console.WriteLine("Constructor özel bir methottur.");
            Console.WriteLine("Geriye dönüş tipi yoktur.");
            Console.WriteLine("Sınıf ismi ile aynıdır.");
            Console.WriteLine("Normal methodlar gibi overload yapılır.");
            Console.WriteLine("Dönüş tipinin olmadığı void olarak algılanmamalıdır.");

        }

        //this anahtar sözcüğü yukarıdaki parametresiz constructorın içerisinin çalıştırır.
        //this()'i parametresiz kullanırsak parametresiz constructorın içerisini alır.
        public Deneme(string metin) : this()
        {
            //Aşağıdaki gibi kod kirliliği yapmamış oluyoruz.
            //Console.WriteLine("Constructor özel bir methottur.");
            //Console.WriteLine("Geriye dönüş tipi yoktur.");
            //Console.WriteLine("Sınıf ismi ile aynıdır.");
            //Console.WriteLine("Normal methodlar gibi overload yapılır.");
            //Console.WriteLine("Dönüş tipinin olmadığı void olarak algılanmamalıdır.");
        }

        //Aşağıdaki constructor ise,parametre alan string metini çağırmış oldu.
        public Deneme(int sayi):this(Convert.ToString(sayi))
        {   

        }
    }
}
