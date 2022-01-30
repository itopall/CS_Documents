using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_NullableTypes
{
    //Nullable tipler, C# generics ile birlikte gelmişlerdir.
    //Struct'lara null atama imkanı sağlar.
    //Özellikle veritabanı programcılığı içim önemli bir yeniliktir.
    //Çünkü, veritabanında sayısal tipler de null alabiliyorken, uygulama tarafında bir Int32'nin null alması mümkün değildir. Nullable tipler sayesinde bu sorun çözülebilir.
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            //Değer türlü tipler null olamazlar! Aşağıdaki satır derleme zamanında hata alır!
            //int a = null;

            //? karakteri int tipinin nullable bir tip olduğunu gösterir. Artık bu değişken null değer alabilir.
            int? a = null;

            //a'yı nullable yaptıktan sonra a'ya null atanabilir, değeri null ile karşılaştırılabilir.
            if (a == null)
                Console.WriteLine("a'nın değeri null'dır");

            //Normal bir int gibi değer de atayabiliriz.
            a = 10;

            //Sonrasında tekrar null atayabiliriz.
            a = null;
            #endregion

            #region Örnek 2
            //Aşağıdaki satırda Ram'in Stack bölgesine System.Int32 nesnesi çıkartılıyorken
            int x = 5;

            //Aşağıdaki satırda ise Ram'in Stack bölgesine System.Nullable<System.Int32> nesnesi çıkar
            int? y = 5;

            //Diğer bir deyişle, int? yalnızca kolay kullanım içindir. Aslında Compiler int? yazımını Nullable<int>'e dönüştürür.
            System.Nullable<int> z = 5; //int? < = 5 demekle aynıdır.
            //z = null;

            //HasValue property'si nullable tipin içerisinde değer olup olmadığını gösterir.
            Console.WriteLine("z'nin değeri {0}", z.HasValue ? "Null Değil" : "Null");

            //Bu satır derleme zamanında hata verir. y ve z nullable olduğu için direkt olarak int bir değişkene atanamaz!
            //int sayi = z;

            //Value property'si üzerinden bir int değişkene atama işlemi yapılabilir.Ancak nullable tipin içerisinde null değer varsa Value property'si hata verir! O yüzden öncelikle nullable tipin içinde değer olduğundan emin olmak gerekir.
            //z = null;
            if (z.HasValue)
            {
                int sayi = z.Value;
            }

            //z null iken z okunur ve null gelir.
            z = null;
            Console.WriteLine("z: {0}", z);
            #endregion

            #region Örnek 3
            short? aa = 10; //Nullable<short> şeklinde de yazılabilir.

            //GetValueOrDefault() methodu, aa'nın null olmaması durumunda aa'yı null olması durumunda ise 0 döner. Bu methodun overload edilmiş versiyonunda default bir değer göndererek, null olması durumunda o değerin dönmesi sağlanabilir.
            int sayi2 = aa.GetValueOrDefault();
            int sayi3 = aa.GetValueOrDefault(-999);
            int sayi4 = aa ?? -999; //?? operatörüyle, nullable nesnenin HasValue'su false olması durumunda atanacak default bir değeri kolay bir şekilde gönderebiliriz.

            //Not: Nullable<> tipinde struct kısıtlaması olduğu için yalnızca değer türlü tiplerin nullable versiyonları yazılabilir.
            #endregion

            Console.ReadKey();
        }
    }
}
