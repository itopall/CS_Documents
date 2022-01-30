using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Thread
{
    class MultipleThreading
    {
        public void StartMultipleOperations()
        {
            Thread th1 = new Thread(new ThreadStart(WriteX));
            Thread th2 = new Thread(new ThreadStart(Write_));

            //Eğer istenirse Thread'lere öncelik verilebilir.
            th1.Priority = ThreadPriority.Lowest;
            th2.Priority = ThreadPriority.Highest;

            th1.Start();
            th2.Start();
        }

        private void WriteX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
            }
        }

        private void Write_()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("_");
            }
        }
    }
}
