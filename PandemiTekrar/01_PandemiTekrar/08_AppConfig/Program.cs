using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailAdress = ConfigurationManager.AppSettings["EmailAdress"];
            string password = ConfigurationManager.AppSettings["Password"];

            Console.WriteLine(emailAdress);
            Console.WriteLine(password);

            Console.ReadKey();
        }
    }
}
