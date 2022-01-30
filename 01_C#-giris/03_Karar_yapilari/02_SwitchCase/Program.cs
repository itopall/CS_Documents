using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string deger = "Bursa";
            #region Switch-Case
            //Swtich(değer) değer kısmına kontrol edilecek değişken yazılır.
            //case kısmına kıyaslama işlemleri gerçekleştirilir.
            //break ise eşleme gerçekleşmesi durumunda çalışak kod bloğunun sona erdiğini gösterir.
            // eğer case'lerden hiçbirsi kontrol edilen değer ile eşleşmiyorsa default kısmı çalışacaktır.

            switch (deger)
            {
                case "istanbul":
                    Console.WriteLine("İstanbul'un plaka kodu: 34");
                    break;
                case "Ankara":
                    Console.WriteLine("Ankara'nın plaka kodu: 06");
                    break;
                case "Bursa":
                    Console.WriteLine("Bursa'nın plaka kodu: 16");
                    break;
                default:
                    Console.WriteLine("Hatalı bir değer girdiniz.");
                    break;
            }
            #endregion

            #region switch-case Goto
            // Caselerde bri çalıştıktan sonra bir başka case'in de çalışmasını istiyorsak goto case ile tön
            string İslemTipi = "satış yap";
            switch (İslemTipi)
            {
                case " Stok eksilt":
                    Console.WriteLine("Stok eksiltme işlemi gerçekleştirildi");
                    break;
                case "Ürün ekle":
                    Console.WriteLine("ürün ekleme işlemi gerçekleştirildi.");
                    break;
                case "satış yap":
                    Console.WriteLine("satış işlemi gerçekleştirildi.");
                    goto case "Stok eksilt";
                default:
                    Console.WriteLine("Hatalı bir işlem tipi girdiniz.");
                    break;
            }

            #endregion

            #region Nested Switch-case 
            int sayi = 5;
            switch (sayi % 5)
            {
                case 0:
                    Console.WriteLine("gelen sayı 5 yada katıdır.");

                    switch(sayi % 10)
                    {
                        case 0:
                            Console.WriteLine("girilen sayı 10 yada katıdır");
                            break;
                        default:
                            Console.WriteLine("Girilen satı 10 yada katı değildir");
                            break;

                    }
                    break;
                case 1:
                    Console.WriteLine("gelen sayı 5 yada katı değildir.");
                    break;
                default:
                    Console.WriteLine("gelen sayı 5 ya da katı değildir.");
                    break;


            }
            #endregion
            Console.ReadKey();
        }
    }
}
