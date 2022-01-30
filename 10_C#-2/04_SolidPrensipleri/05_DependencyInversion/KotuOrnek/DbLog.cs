using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DependencyInversion.KotuOrnek
{
    class DbLog
    {
        public bool WriteLog(string value)
        {
            Console.WriteLine("Db Log yazıldı...");
            return true;
        }
    }
}
