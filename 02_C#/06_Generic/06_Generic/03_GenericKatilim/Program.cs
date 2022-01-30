using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericKatilim
{
    class Program
    {
        static void Main(string[] args)
        {
            new BaseClass<int>().GenericProperty = 5;
            new BaseClass<string>().GenericProperty = "10";
            new ChildClass().GenericProperty = 10;
            new ChildClass().GenericProperty = 10;
            new ChildClass2<string>().GenericProperty = "test";
            new ChildClass2<DateTime>().GenericProperty = DateTime.Now;
            new ChildClass3<char>().GenericProperty = "Deneme";
            new ChildClass3<DateTime>().GenericProperty = "Deneme2";

            Console.ReadKey();
        }
    }

    class BaseClass<T>
    {
        public T GenericProperty { get; set; }
    }

    //Kalıtım yapılırken de Generic sınıfa ait generic parametrelere değerler gönderilmek zorunludur!
    class ChildClass : BaseClass<int>
    {
        //Baseclass'daki GenericProperty int tipinde buraya gelecek
    }

    //ChildClass2 tipinden nesne üretilirken T yerine gönderilen tip kalıtım alınan BaseClass'a gönderilerek BaseClass'ın da bu tipe göre çalışması sağlanabilir.
    class ChildClass2<T> : BaseClass<T>
    {
        //Nesne üretilirken T yerine int gönderilmişse BaseClass'daki GenericProperty int tipinde çalışır
    }

    //GenericClass3 generic olmasına rağmen BaseClass'ın her daim string tipinde kalıtım vermesi aşağıdaki şekilde sağlanabilir. GenericProperty her daim string olarak gelir.
    class ChildClass3<T> : BaseClass<string>
    {

    }
}
