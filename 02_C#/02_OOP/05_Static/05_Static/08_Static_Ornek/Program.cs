using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Static_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmailHelper static classının içerisnde sadece MailGonder() metodu kalsın.
            //Diğer tüm propertyler non static olarak oluşturalım Email classı içerisinde non static olarak tanımlansın 
            //EmailGonder metotdu parametre olarak email  classı tipinde bir nesne alsın ve yine aynı şeyi yazdırsın.
            Email mail = new Email("İlker", "Messi", "static ile ilgili ödev", "Aşağıdaki örnekleri çözmeni istiyorum");
            Email mail2 = new Email("nasılsın", "Ayşe", "merhaba", "Ali");
            //EmailHelper sınıfında MailGonder metodu Email classı tipinde bir nesne istediği için MailGonder() metodu içerisine parametre olarak Email sınıfından oluşturduğumuz nesneyi veriyoruz
            EmailHelper.MailGonder(mail);
            EmailHelper.MailGonder(mail2);
            Console.ReadKey();
        }
    }
}
