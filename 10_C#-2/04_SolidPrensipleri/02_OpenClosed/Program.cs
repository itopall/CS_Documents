using _02_OpenClosed.DogruOrnek;
using _02_OpenClosed.KotuOrnek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OpenClosed
{
    //(O)pen/Closed Principle
    //Sınıflar, ve methodlar değişikliğe kapalı ancak gelişime açık olmalıdır.

    class Program
    {
        static void Main(string[] args)
        {
            //Kötü Örnek
            //Logger logger = new Logger();
            //logger.WriteLog(LogType.Db, "Bu log Veritabanına yazılsın...");
            //logger.WriteLog(LogType.Xml, "Bu log Xml yazılsın...");
            //logger.WriteLog(LogType.Json, "Bu log Json yazılsın...");

            //Doğru Örnek
            Log log = new Log(new DbLog());
            log.WriteLog("Bu log Veritabanına yazılsın...");

            Log log2 = new Log(new XmlLog());
            log2.WriteLog("Bu log Xml'e yazılsın...");

            Log log3 = new Log(new JsonLog());
            log3.WriteLog("Bu log Json'a yazılsın...");

            Console.ReadKey();
        }
    }
}
