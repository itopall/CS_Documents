using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DependencyInversion.DogruOrnek
{
    class LoggerNew
    {
        ILogger _logger;
        public LoggerNew(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string value)
        {
            _logger.WriteLog(value);
        }
    }
}
