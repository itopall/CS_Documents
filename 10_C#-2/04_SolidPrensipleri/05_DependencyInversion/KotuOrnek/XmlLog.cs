using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DependencyInversion.KotuOrnek
{
    class XmlLog
    {
        public bool WriteLog(string value)
        {
            Console.WriteLine("Xml Log yazıldı...");
            return true;
        }
    }
}
