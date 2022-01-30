using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03_TypeOfKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type sınıfının amacı, bir tip hakkında bilgi almamızı sağlar.
            //typeof keyword'ü Parametre olarak aldığı bir tip hakkında bilgi veren bir Type nesnesi döner
            Type tip = typeof(string);
            tip = typeof(int);
            tip = typeof(long);
            tip = typeof(char);
            //Type tipinin static GetType() methoduyla string olarak tip adı verilerek, bir Type nesnesi üretilebilir.
            tip = Type.GetType("System.Double");

            //Bir değişken üzerinden de Type nesnesi elde edilebilir.
            //GetType methodu object tipinde tanımlı bir methoddur; dolayısıyla tüm .Net nesneleri üzerinden çağrısı yapılabilir.Çağrısı yapılan tip hakkında bilgi veren bir Type nesnesi elde etmemizi sağlar.
            bool durum = false;
            tip = durum.GetType();

            Console.WriteLine("Tam adı: {0}",tip.FullName);
            Console.WriteLine("Kısa adı: {0}",tip.Name);
            Console.WriteLine("Namespace: {0}",tip.Namespace);
            Console.WriteLine("Method sayısı: {0}",tip.GetMethods().Length);
            Console.WriteLine("Property sayısı: {0}",tip.GetProperties().Length);

            //Tip'ten gelen method listesini ekrana yazdırma
            MethodInfo[] methods = tip.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.ReadKey();
        }
    }
}
