using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DateTime_islemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Manuel olarak Tarih set etme
            DateTime manuelTarih = new DateTime(2019, 10, 12);
            Console.WriteLine(manuelTarih);
            DateTime manuelTarih2 = new DateTime(2019, 10, 1, 10, 10, 0);
            Console.WriteLine(manuelTarih2);

            #endregion

            #region Bugünün tarih bilgisi
            //DateTime.Now bugünün tarih ve saat bilgisinin getirir.
            DateTime bugun = DateTime.Now;
            Console.WriteLine(bugun);

            //Yıl,ay,gün, saat, dakika, saniye bilgilerini ayrı ayrı elde etme
            Console.WriteLine("Yil = {0}", bugun.Year);
            Console.WriteLine("Ay = {0}", bugun.Month);
            Console.WriteLine("Gun = {0}", bugun.Day);
            Console.WriteLine("Saat = {0}", bugun.Hour);
            Console.WriteLine("Dakika = {0}", bugun.Minute);
            Console.WriteLine("Saniye = {0}", bugun.Second);

            Console.WriteLine("Tarih: {0}", bugun.Date);

            //Tarih ve sat bilgilerini uzun ve kısa formatları ile elde etme
            Console.WriteLine(bugun.ToShortDateString());
            Console.WriteLine(bugun.ToLongDateString());
            Console.WriteLine(bugun.ToShortTimeString());
            Console.WriteLine(bugun.ToLongTimeString());
            #endregion

            #region DateTime Convert
            DateTime date, time;

            //string bir değeri datetime tipine çevirir.
            date = Convert.ToDateTime("12.10.2019");
            Console.WriteLine(date);

            // string bir saat bilgisisni datetie formatına çevirir tarih olarak o günün tarihini bilgisi gelir.
            time = Convert.ToDateTime("13:36");
            Console.WriteLine(time);
            #endregion

            #region DayOfYear
            DateTime tarih = DateTime.Now;
            Console.WriteLine("Yilin gunu: {0}", tarih.DayOfYear);


            #endregion

            #region DayOfWeek
            Console.WriteLine("Yilin gunu: {0}", tarih.DayOfWeek);
            Console.WriteLine("Yilin gunu: {0}", (int)tarih.DayOfWeek);
            #endregion

            #region tıl ekleme/çıkarma
            Console.WriteLine(tarih.AddYears(10));
            Console.WriteLine(tarih.AddYears(-10));
            #endregion

            #region Ay ekleme/çıkarma
            Console.WriteLine(tarih.AddMonths(10));
            Console.WriteLine(tarih.AddMonths(-10));
            #endregion

            #region gün ekleme/çıkarma
            Console.WriteLine(tarih.AddDays(10));
            Console.WriteLine(tarih.AddDays(-10));
            #endregion

            #region Saat ekleme/çıkarma
            Console.WriteLine(tarih.AddHours(10));
            Console.WriteLine(tarih.AddHours(-10));
            #endregion

            #region dakika ekleme/çıkarma
            Console.WriteLine(tarih.AddMinutes(10));
            Console.WriteLine(tarih.AddMinutes(-10));
            #endregion

            #region saniye ekleme/çıkarma
            Console.WriteLine(tarih.AddSeconds(10));
            Console.WriteLine(tarih.AddSeconds(-10));
            #endregion

            #region Artık yıl mı
            //IsLeapYear methodu True dönerse artık yıl demektir.
            Console.WriteLine(DateTime.IsLeapYear(2020));
            #endregion

            #region Tarih aralığı
            DateTime tarih1 = new DateTime(2018, 1, 1);
            DateTime tarih2 = new DateTime(2019, 1, 1);
            TimeSpan ts = new TimeSpan();//iki tarih aralığındaki farkı almak için TimeSpan kullanırız.
            ts = tarih2 - tarih1;
            Console.WriteLine("gün: {0}", ts.TotalDays);
            Console.WriteLine("saat: {0}", ts.TotalHours);
            Console.WriteLine("dakika: {0}", ts.TotalMinutes);


            #endregion





            Console.ReadKey();
        }
    }
}
