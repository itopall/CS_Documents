using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OperatorleriAsiriYuklemek
{
    //Bir operatörün, yazılan bir tip için davranışının bildirilmesine operatörü aşırı yüklemek (operator overloading) denir.
    //Operator aşırı yüklenmesi yazılan tipler için oldukça kolay kullanımlar oluşturabilir
    class Program
    {
        static void Main(string[] args)
        {
            #region Nokta ve Çizgi ile + operatörü kullanımı
            //+ operatörünün overload edilerek kullanılması
            Nokta n1 = new Nokta(10, 20);
            Nokta n2 = new Nokta(100, 200);
            Cizgi sonuc1 = n1 + n2;

            //Normal toplama işlemi
            int sayi1 = 10;
            int sayi2 = 20;
            int sonuc2 = sayi1 + sayi2;
            #endregion

            #region SatisElemani Ornek Kullanımı
            SatisElemani e1 = new SatisElemani("Ali Veli", 10, new TimeSpan());
            SatisElemani e2 = new SatisElemani("Hasan Hüseyin", 50, new TimeSpan());

            //Operatör aşırı yüklenmeden ilgili sonuç aşağıdaki şekilde tabiki üretilebilir, ancak operatör aşırı yüklenerek oluşan kullanım, kodlamayı kolaylaştırır.
            //int s1 = e1.SatisAdedi + e2.SatisAdedi;

            int s2 = e1 + e2;
            int s3 = e1 + 1000;
            int s4 = e1 - e2;
            int s5 = e1 - 5;

            bool s6 = e1 == e2;
            bool s7 = e1 != e2;
            bool s72 = sayi1.Equals(e2);

            //bool s8 = e1.SatisAdedi > e2.SatisAdedi;
            bool s8 = e1 > e2;
            bool s9 = e1 < e2;
            bool s10 = e1 >= e2;
            bool s11 = e1 <= e2;
            #endregion

            #region C# içerisinde kullanılan operator override yerleri
            DateTime tarih = DateTime.Now;
            TimeSpan sure = TimeSpan.FromHours(20);
            DateTime sonTarih = tarih + sure;
            Console.WriteLine(sonTarih);
            #endregion


            Console.ReadKey();
        }
    }
}
