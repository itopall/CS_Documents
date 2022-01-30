using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DependencyInversion.KotuOrnek
{
    class Logger
    {
        XmlLog _xmlLog;
        public Logger()
        {
            _xmlLog = new XmlLog();
        }

        public void Log(string value)
        {
            _xmlLog.WriteLog(value);
        }
    }
}
