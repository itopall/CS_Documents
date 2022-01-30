using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Thread
{
    class SingleThreading
    {
        public void StartSingleOperations()
        {
            Thread thread = new Thread(new ThreadStart(work1));
            thread.Start();
        }

        private void work1()
        {
            //ThreadId değeri çoklu thread'lerde işler karmaşıklaştığı için hangi işlemin hangi thread tarafından gerçekleştirildiğini yakalamakta bize yardımcı olur.
            Console.WriteLine("Thread 1 çalıştı Thread: {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
