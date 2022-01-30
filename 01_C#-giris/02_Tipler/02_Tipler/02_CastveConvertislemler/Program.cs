using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CastveConvertislemler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Convert 1
            string str = "10";
            int sayi1 = Convert.ToInt32(str);

            Console.WriteLine("Sonuc:" + sayi1);
            #endregion
            #region Cast 1
            int ortanca = 100;
            short kucuksayi = 20;
            kucuksayi = (short)ortanca;


            //double değişkendeki ondalıklı kısım int tipinde cast edilirken kesilecektir.
            double a = 1234.7;
            int b;
            b = (int)a;//Herhangi bir yuvarlama yapmaz.
            Console.WriteLine("a nin cast edilmiş hali: " + b);

            int c = Convert.ToInt32(a);//Yuvarlama yapar.
            Console.WriteLine("a nin convert edilmiş hali:" + c);
            #endregion


            #region Convert İşlemleri
            bool boolTest = Convert.ToBoolean(0);
            char charTest = Convert.ToChar('E');
            double doubleTest = Convert.ToDouble("1234");
            short shortTest = Convert.ToInt16("20");
            int intTest = Convert.ToInt32("20");
            long longTest = Convert.ToInt64("20");
            float floatTest = Convert.ToSingle("20");
            ushort ushortTest = Convert.ToUInt16("20");
            uint uintTest = Convert.ToUInt32("20");
            ulong ulongTest = Convert.ToUInt64("20");
            string stingTest = Convert.ToString(100);
            string stringTest2 = 100.ToString();//string değerler ekstra olarak bu şekilde convert edilebilir.
            DateTime datetime = Convert.ToDateTime("01.01.2019");


            #endregion




            Console.ReadKey();
        }
    }
}
