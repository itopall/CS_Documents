using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Static_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Emailhelper adında static bir class oluşturalım
            //içerisinde From, To, Title, Body propertyleri olsun.
            //MailGonder adında metot tanımlayalım.
            //Metot çağırıldığında "From"dan To'ya title başlıklı body gövdeli mail gönderildi.
            EmailHelper.MailGonder("İlker", "Messi", "static ile ilgili ödev", "Aşağıdaki örnekleri çözmeni istiyorum");

            Console.ReadKey();
        }
    }
}
