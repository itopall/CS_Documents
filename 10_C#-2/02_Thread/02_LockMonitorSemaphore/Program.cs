using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_LockMonitorSemaphore
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LockTest
            //LockTest lockTest = new LockTest();

            //Thread t1 = new Thread(() => lockTest.Tetikleyici1());
            //Thread t2 = new Thread(() => lockTest.Tetikleyici2());
            //Thread t3 = new Thread(() => lockTest.Tetikleyici3());

            //t1.Start();
            //t2.Start();
            //t3.Start();
            #endregion

            #region Monitor
            //MonitorTest monitorTest = new MonitorTest();

            //Thread t1 = new Thread(() => monitorTest.Tetikleyici1());
            //Thread t2 = new Thread(() => monitorTest.Tetikleyici2());
            //Thread t3 = new Thread(() => monitorTest.Tetikleyici3());

            //t1.Start();
            //t2.Start();
            //t3.Start();
            #endregion

            #region Semaphore
            SemaphoreTest semaphoreTest = new SemaphoreTest();

            Thread t1 = new Thread(() => semaphoreTest.Tetikleyici1());
            Thread t2 = new Thread(() => semaphoreTest.Tetikleyici2());
            Thread t3 = new Thread(() => semaphoreTest.Tetikleyici3());

            t1.Start();
            t2.Start();
            t3.Start();
            #endregion

            Console.ReadKey();
        }
    }
}
