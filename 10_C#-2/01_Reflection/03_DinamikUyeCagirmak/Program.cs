using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03_DinamikUyeCagirmak
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun();
            urun.Id = 1;
            urun.Ad = "Laptop";
            urun.Fiyat = 2000;

            Urun urun2 = new Urun
            {
                Id = 1,
                Ad = "",
                Fiyat = 3000
            };

            #region Dinamik Property Çağırma - 1
            //Hangi üye dinamik kullanılacaksa, o üyenin Info nesnesi oluşturulur. (Örneğin, PropertyInfo, MethodInfo, FieldInfo vb.)
            //Console.WriteLine("Hangi property'e erişmek istiyorsunuz?: ");
            //string propertyAdi = Console.ReadLine();

            //PropertyInfo okunacakProperty = typeof(Urun).GetProperty(propertyAdi);
            //if (okunacakProperty == null)
            //{
            //    Console.WriteLine("Girdiğiniz property bu class'da bulunmamaktadır!");
            //}
            //else
            //{
            //    Console.WriteLine("{0} property'sinin değeri: {1}", okunacakProperty.Name, okunacakProperty.GetValue(urun));
            //}
            #endregion

            #region Dinamik Property Çağırma - 2
            //DateTime tarih = DateTime.Now;

            //Console.WriteLine("Property giriniz: ");
            //string propertyAdi2 = Console.ReadLine();

            //PropertyInfo okunacakProperty2 = tarih.GetType().GetProperty(propertyAdi2);
            //Console.WriteLine("{0} property'sinin değeri: {1}", okunacakProperty2.Name, okunacakProperty2.GetValue(tarih));
            #endregion

            #region Dinamik Method Çağırma
            Random rnd = new Random();

            Console.WriteLine("Random nesnesinin hangi methodunu tetiklemek istiyorsunuz?: ");
            string methodAdi = Console.ReadLine();

            MethodInfo mi = rnd.GetType().GetMethod(methodAdi, new Type[0]);

            Console.WriteLine("Sonuç : {0}", mi.Invoke(rnd, null));
            #endregion

            Console.ReadKey();
        }
    }

    class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
    }

    //Configuration tablosunu db'de aşağıdaki şekilde açtığımızı düşünürsek ParametreTipi alanına (int, string, DateTime) gibi tipler belirtilmeli ve Deger kısmına da bu tiplere uygun değerler girilmeli. Yani Tip ParametreTipi int ise Deger 1,2,3 gibi sayısal değerler olmalı, string ise metinsel değerler olmalı vs. 
    //Sonrasın bu generic yapıyı c# içerisinde kurgulayabilmek için ParametreTipi'ne göre value'yu dinamik Nesne Üretme yöntemiyle ParametreTipi'ne göre ürettiğimiz nesneye aktarma yolunu izleyebiliriz. 
    //class Configuration
    //{
    //    public int Id { get; set; }
    //    public string ParametreAdi { get; set; }
    //    public string ParametreTipi { get; set; }
    //    public object Deger { get; set; }
    //}

    //1, SessionTimeOutSüresi, int,       60
    //2, FromMailAdresi,       string,    admin @gmail.com
}
