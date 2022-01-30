using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_CultureInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Örnek ana kültürler: en, tr, de
            //Örnek alt kültürler: en-US, en-GB, tr-TR
            //Ana kültürler, alt kültürleri gruplayan kültür nesneleridir.
            //Alt kültürler programa uygulamanın kültür bilgisi olarak atanabilirler.

            #region Ana Kültür
            CultureInfo cultureInfo = new CultureInfo("en");
            Console.WriteLine(cultureInfo.Name);
            Console.WriteLine(cultureInfo.NativeName);
            Console.WriteLine(cultureInfo.DateTimeFormat.ShortDatePattern);
            #endregion

            #region Alt Kültür
            CultureInfo cultureInfo2 = new CultureInfo("en-GB");
            Console.WriteLine("DisplayName: {0}", cultureInfo2.DisplayName);
            Console.WriteLine("Parent: {0}", cultureInfo2.Parent.Name);
            Console.WriteLine(1000.75.ToString("C"));
            #endregion

            #region Programın Kullandığı Kültürü Elde Etme
            CultureInfo cultureInfo3 = Thread.CurrentThread.CurrentCulture;
            Console.WriteLine("Current Culture: {0}", cultureInfo3.DisplayName);
            Console.WriteLine("Current Culture Parent: {0}", cultureInfo3.Parent.Name);
            Console.WriteLine("Current Culture Native Name: {0}", cultureInfo3.NativeName);
            Console.WriteLine(1000.75.ToString("C"));
            #endregion

            #region Programın Kullandığı Kültürü Değiştirmek
            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");

            CultureInfo cultureInfo4 = Thread.CurrentThread.CurrentCulture;
            Console.WriteLine("Current Culture: {0}", cultureInfo4.DisplayName);
            Console.WriteLine("Current Culture Parent: {0}", cultureInfo4.Parent.Name);
            Console.WriteLine("Current Culture Native Name: {0}", cultureInfo4.NativeName);
            Console.WriteLine(1000.75.ToString("C"));
            #endregion

            #region Kültür Listesini Almak
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (CultureInfo ci in cultures)
                Console.WriteLine(ci.DisplayName);
            #endregion

            Console.ReadKey();
        }
    }
}
