using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OpenClosed.DogruOrnek
{
    class Log
    {
        ILogger _logger;
        public Log(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteLog(string value)
        {
            _logger.WriteLog(value);
        }
    }
}
