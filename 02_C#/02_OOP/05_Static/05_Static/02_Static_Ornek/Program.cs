using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Static_Ornek
{
    class Program
    {
        //nonstatic field oluşturma
        int nonStaticField;
        //static Field oluşturma
        static int staticField;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.nonStaticField = 30;
            //nesne üreterek static Field'a ulaşamayız.
            //p.staticField = 20;

            //Static üyelere yine dirkt class isiminden ulaşabiliriz.
            Program.staticField = 13;
            Program.StaticMethod();

            //sistemde var olan bazı static classlar.
            //Math sınıfı,console sınıfı, convert sınıfı....

            Console.ReadKey();
        }
        //static method tanımlama
        static public void StaticMethod()
        {
            //this() keyword'u kullanılamaz.Staticlerin içinde.Çünkü static methodu bir porgram nesnesi için çalışmaz.
            //static method içerisinden nonstatic methoda erişim
            Program p = new Program();
            p.nonStaticField = 20;
            p.nonStaticMethod();

            //static field ve method erişimi
            //Class ismiyle ulaşırız.Her hangi bir sınıftan nesne üretimi yoktur Derikt class isminden ulaştık.
            Program.staticField = 15;
            Program.StaticMethod();
        }
        //nonstatic method tanımlama

        public void nonStaticMethod()
        {
            int sayi = this.nonStaticField;
            Program.staticField = 30;
            Program.StaticMethod();
            //aşağıdaki şekildede ulaşım sağlanır.
            staticField = 25;

            nonStaticField = 34;
        }
    }
}
