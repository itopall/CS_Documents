using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_LockMonitorSemaphore
{
    //lock deyimi C# dilinin sunduğu pratik bir senkronizasyon mekanizmasıdır. IslemYap() methodunun birden çok thread tarafından işletilmekte olduğunu düşünelim. lock (kilit) aşamasına ilk gelen thread ilgili bloğun işletim hakkını kazanır. Bu blok bu thread tarafından tamamlanmadan başka bir thread aynı aşamaya geldiğinde ilk thread'in işini bitirmesini beklemek zorundadır. Bu thread'lerin sayısı ne kadar çok olursa olsun hepsi beklemek zorundadır. İlk thread bloğun işletimini bitirdiği anda bloğun işletim hakkı bekleyen thread'ler arasında ilk gelen ilk hizmet alır mantığıyla diğer bir thread'e geçer. Böylelikle bu örnekte sayac değişkeninin değerinin artması ve ardından değerinin test edilmesi işlemi bölünmeden gerçekleşmiş olur.
    class LockTest
    {
        private static readonly object kilit = new object();
        private int sayac = 0;

        public void IslemYap()
        {
            lock (kilit)
            {
                sayac++;
                Console.WriteLine("ThreadId: {0} Sayac: {1}", Thread.CurrentThread.ManagedThreadId, sayac);

                if (sayac == 10)
                {
                    sayac = 0;
                    Console.WriteLine("ThreadId: {0} Sayac SIFIRLANDI!!", Thread.CurrentThread.ManagedThreadId);
                }
            }
        }

        public void Tetikleyici1()
        {
            //Ekstra İşlemler

            for (int i = 0; i < 20; i++)
                IslemYap();
        }

        public void Tetikleyici2()
        {
            //Ekstra İşlemler

            for (int i = 0; i < 20; i++)
                IslemYap();
        }

        public void Tetikleyici3()
        {
            //Ekstra İşlemler

            for (int i = 0; i < 20; i++)
                IslemYap();
        }
    }
}
