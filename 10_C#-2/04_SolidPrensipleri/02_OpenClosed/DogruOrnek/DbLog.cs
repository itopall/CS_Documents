using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OpenClosed.DogruOrnek
{
    class DbLog : ILogger
    {
        public bool WriteLog(string value)
        {
            Console.WriteLine("Db log yazıldı... Detay: {0}", value);

            return true;
        }
    }
}
