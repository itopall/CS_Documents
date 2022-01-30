using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_NameOfOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();

            
            Console.WriteLine("{0}: {1}","Name",personel.Name);
            Console.WriteLine("{0}: {1}","Age",personel.Age);

            //nameof operatörü sayesinde ilgili property'nin adını elde ettik.
            Console.WriteLine("{0}: {1}", nameof(Personel.Name), personel.Name);
            Console.WriteLine("{0}: {1}", nameof(Personel.Age), personel.Age);

            Console.ReadKey();
        }
    }
    class Personel
    {
        public string Name { get; set; } = "Ali";
        public int Age { get; set; } = 21;
    }
}
