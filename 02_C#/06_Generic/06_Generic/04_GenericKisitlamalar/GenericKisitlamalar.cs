using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_GenericKisitlamalar
{
    //1) T yerine sadece class'ların gelmesini sağlamak
    //T yerine gelecek tipin yalnızca class olabileceğini belirttik
    class SadeceClasslar<T> where T : class
    {
    }

    //2) T yerine sadece struct'ların gelmesini sağlamak
    //T yerine gelecek tipin yalnızca struct olmak zorunda olduğunu belirttik
    class SadeceStructlar<T> where T : struct
    {
    }

    //3) T yerine bir interface'i implement etmeye zorlamak
    //T yerine gelecek tipin sadece IEnumerable interface'ini implement etmiş olmak zorunda olduğunu belirttik.
    class SadeceForeachIleGezilebilenler<T> where T : IEnumerable
    {
    }

    //T yerine gelecek tipin sadece IComparable interface'ini implement etmiş olmak zorunda olduğunu belirttik.
    class SadeceKarsilastirilabilenler<T> where T : IComparable
    {
    }

    //4) Belli bir sınıftan kalıtılmış olmaya zorlamak
    //T yerine gelecek tipin Urun ya da Urun'den kalıtılmış olmak zorunda olduğunu belirttik!
    //Yani T yerine Urun, Kitap ya da Defter sınıfları gelebilir. Bu sınıfların dışında hiç bir tip gelemez!
    class SadeceUrunler<T> where T : Urun
    {
    }

    //T yerine gelecek tipin sadece Defter ya da Defter'den kalıtım alan bir tip varsa o tipden olabileceğini belirttik.
    class SadeceDefter<T> where T : Defter
    {
    }

    //5) Varsayılan ctor'u olmaya zorlamak
    //T yerine gelecek tipin mutlaka varsayılan ctor'u olmalıdır
    //Kısacası örneklenmesi garanti olacak bir tipin gelmesi garanti altına alınmış olur.
    class SadeceOrneklenmesiGarantiOlanlar<T> where T : new()
    {
        //Sınıfın içinde T tipinden bir nesne oluşturulmaya çalışılması durumunda ctor'un zorunlu olması istenebilir.
        void Test()
        {
            T obj = new T();
        }
    }

    //T için birden fazla kısıt uygulanmak istenirse aşağıdaki gibi virgül ile diğer kısıt da eklenebilir.
    //T yerine gelecek tip hem IEnumerable hem de IComparable olmak zorundadır.
    class ForeachIleGezilebilenVeKarsilastirilabilenler<T> where T: IEnumerable, IComparable
    {
    }

    //T yerine gelecek tip hem class hem de IEnumarable'ı implement etmiş olmak zorundadır.
    class SadeceForeachIleGezilebilenSiniflar<T> where T : class, IEnumerable
    {
    }

    class Test<T, K, L> 
                        where T : class 
                        where K : class, IEnumerable
                        where L : struct
    {
    }
}
