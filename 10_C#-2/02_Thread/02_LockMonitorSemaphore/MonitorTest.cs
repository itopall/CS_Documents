using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_LockMonitorSemaphore
{
    //C# dilindeki lock deyimi aslında Monitor.Enter ve Monitor.Exit çağrılarının kısayolundan oluşur. Yani lock ile monitor yapıları aynı işi yapmaktadır.
    class MonitorTest
    {
        private static readonly object kilit = new object();
        private int sayac = 0;

        public void IslemYap()
        {
            Monitor.Enter(kilit);
            try
            {
                sayac++;
                Console.WriteLine("ThreadId: {0} Sayac: {1}", Thread.CurrentThread.ManagedThreadId, sayac);

                if (sayac == 10)
                {
                    sayac = 0;
                    Console.WriteLine("ThreadId: {0} Sayac SIFIRLANDI!!", Thread.CurrentThread.ManagedThreadId);
                }
            }
            finally
            {
                Monitor.Exit(kilit);
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
