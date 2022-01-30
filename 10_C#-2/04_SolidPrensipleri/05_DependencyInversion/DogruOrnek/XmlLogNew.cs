using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DependencyInversion.DogruOrnek
{
    class XmlLogNew : ILogger
    {
        public bool WriteLog(string value)
        {
            Console.WriteLine("Xml Log yazıldı...");
            return true;
        }
    }
}
