using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OpenClosed.KotuOrnek
{
    class Logger
    {
        XmlLogger _xmlLogger;
        DbLogger _dbLogger;
        JsonLogger _jsonLogger;
        public Logger()
        {
            _xmlLogger = new XmlLogger();
            _dbLogger = new DbLogger();
            _jsonLogger = new JsonLogger();
        }

        public void WriteLog(LogType type, string value)
        {
            switch (type)
            {
                case LogType.Xml:
                    _xmlLogger.WriteLog(value);
                    break;
                case LogType.Db:
                    _dbLogger.WriteLog(value);
                    break;
                case LogType.Json:
                    _jsonLogger.WriteLog(value);
                    break;
                default:
                    break;
            }
        }
    }
}
