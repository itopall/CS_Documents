using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_GenericKisitlamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            new GenericClass<int>();
            new GenericClass<string>();
            new GenericClass<Urun>();
            new GenericClass<Defter>();
            new GenericClass<Kitap>();

            new SadeceClasslar<Urun>();
            new SadeceClasslar<Defter>();
            new SadeceClasslar<Kitap>();
            //new SadeceClasslar<int>(); //int bir class olmadığı için T yerine gönderilemez
            new SadeceStructlar<int>();
            new SadeceStructlar<StructTest>();
            //new SadeceStructlar<Urun>(); //Urun bir struct olmadığı için T yerine gönderilemez
            new SadeceForeachIleGezilebilenler<SadeceForeachIleGezilebilen>();
            new SadeceKarsilastirilabilenler<SadeceKarsilastirilabilen>();
            new SadeceUrunler<Urun>();
            new SadeceUrunler<Defter>();
            new SadeceUrunler<Kitap>();
            new SadeceDefter<Defter>();
            new SadeceOrneklenmesiGarantiOlanlar<Urun>(); //Yazmasak da default ctor var o yüzden örneklenebilir.
            //new SadeceOrneklenmesiGarantiOlanlar<Orneklenemeyen>(); //Orneklenemeyen class'ı private ctor'a sahip olduğu için parametre olarak T yerine gönderilemez.
            new ForeachIleGezilebilenVeKarsilastirilabilenler<GezilebilenVeKarsilastirilabilen>();
            new SadeceForeachIleGezilebilenSiniflar<SadeceForeachIleGezilebilen>();
            new Test<Urun, SadeceForeachIleGezilebilen, StructTest>();

            Console.ReadKey();
        }
    }

    //Generic kısıt tanımlanmadığı takdirde T yerine herhangi bir .Net tipi gelebilir.
    class GenericClass<T>
    {
        public T GenericProperty { get; set; }
    }

    struct StructTest
    {
    }

    class SadeceForeachIleGezilebilen : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class SadeceKarsilastirilabilen : IComparable
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }

    class Orneklenemeyen
    {
        private Orneklenemeyen()
        {
        }
    }

    class GezilebilenVeKarsilastirilabilen : IEnumerable, IComparable
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
