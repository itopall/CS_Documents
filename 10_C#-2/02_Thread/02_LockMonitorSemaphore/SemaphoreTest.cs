using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_LockMonitorSemaphore
{
    //Semaphore, lock ve mutex'in aksine senkronize erişimi tamamen bekletmek değil sınırlandırmak için kullanılır. Bu ne demek? Diyelim ki sınırlı bir kaynağımız var, aynı anda 5 thread'in erişimi sistem için sorun olmuyor ama 5'den fazla thread o kaynak kullanılmak istendiğinde performans sorunu yaşanıyor ve dolayısıyla kodun o bölümünü bütün thread'lerin erişimine açmak istemiyoruz. Bu durumda sayaçlı bir lock mekanizmasına ihtiyacımız var. İşte o mekanızmanın adı Semaphore.
    class SemaphoreTest
    {
        private Semaphore sem = new Semaphore(1, 5, "SemaphoreTest");

        //İzin verilen = 2, başlarken kullanılmış = 1
        public void IslemYap()
        {
            sem.WaitOne();
            try
            {
                Thread.Sleep(2000);
                Console.WriteLine("ThreadId: {0} İşlemer devam ediyor...", Thread.CurrentThread.ManagedThreadId);
            }
            finally
            {
                sem.Release(1);
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
