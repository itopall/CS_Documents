using _05_DependencyInversion.DogruOrnek;
using _05_DependencyInversion.KotuOrnek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DependencyInversion
{
    //(D)ependency Inversion Principle
    //Bağımlılığın ters çevrilmemesi gerektiğini söyler. Üst seviye sınıflar alt seviyeli sınıflara bağımlı olmamalıdır ve bu sınıflardaki değişiklikler yüzünden kendi içlerinde değişiklik yapılması gerekmeyecek şekilde tasarlanmalıdır.
    class Program
    {
        static void Main(string[] args)
        {
            #region Kotu Örnek
            Logger logger = new Logger();
            logger.Log("Hata örneği...");
            #endregion

            #region Dogru Örnek
            //LoggerNew loggerNew = new LoggerNew(new XmlLogNew());
            LoggerNew loggerNew2 = new LoggerNew(new DbLogNew());
            loggerNew2.Log("test");
            #endregion

            Console.ReadKey();
        }
    }
}
