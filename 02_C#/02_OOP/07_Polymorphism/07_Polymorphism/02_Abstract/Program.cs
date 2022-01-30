using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract calsslardan nesne oluşturulmaz.
            //Personel p = new Personel();

            //Tüm derived classlardaki,salary property'si kendi get işlemine göre çalıştı.
            //Bu işlemi base class'taki, abstract propertyî implemente ederek yeni tekrardan üzerine yazarak abstract property'i ezerek yapmış olduk. 
            Muhabeci m = new Muhabeci("Ali Ay", 5, 100);
            Console.WriteLine("{0}'ın maaşı: {1} ", m.NameSurmane, m.salary);

            Satici s = new Satici("Ayşe Güneş", 10, 4,150,3);
            Console.WriteLine("{0}'in maaşı: {1} ", s.NameSurmane, s.salary);

            Hizmetli h = new Hizmetli("Rüştü Asyalı",20,1000);
            Console.WriteLine("{0} 'nın maaşı: {1} ", h.NameSurmane, s.salary);
            Console.ReadKey();
        }
    }
}
