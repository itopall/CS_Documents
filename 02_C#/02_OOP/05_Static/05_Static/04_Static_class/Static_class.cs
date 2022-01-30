using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Static_class
{
    static class Static_class
    {
        //static olarak tanımlanmış class içerisindeki tüm üyeler static olmak zorundadır.

        //Bu yüzden static class içeerinde nonstatic methodlar,propertyler, fieldlar tanımlamaz.

        //public void nonStaticMethod()
        //{

        //}
        //public string nonStaticProperty1 { get; set; }
        //public int nonstaticProperty2 { get; set; }

        //nonstatic fieldlar tanımlayamayız.
        //public int nonStaticField;

        //static classın constructorı
        //Static constructorın erişim belirleyicisi yoktur
        //Parametre almazlar.Overload static methodd yapamıyoruz.
        static Static_class()
        {
            Console.WriteLine("static class oluşturuldu.");
        }
        //satc field tanımlamış olduk
        public const double Pi = 3.14;//bu hep sabittir hiçbir yerde değiştiremeyiz.

        //static property tanımlayalım
        public static int staticProperty { get; set; }

        //static method tanımlaması
        public static void staticMethod()
        {
            
            Console.WriteLine("static method tanımlandı.");
        }

    }
}
