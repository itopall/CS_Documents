using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor) , ConfigurationManager.AppSettings["BackgroundColor"]);

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor) , ConfigurationManager.AppSettings["ForeColor"]);

            Console.WindowWidth = Convert.ToInt32(ConfigurationManager.AppSettings["Width"]);

            
            Console.Clear();

            int x = Convert.ToInt32(ConfigurationManager.AppSettings["X"]);
            int y = Convert.ToInt32(ConfigurationManager.AppSettings["Y"]);
            string message = Convert.ToString(ConfigurationManager.AppSettings["Message"]);

            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
