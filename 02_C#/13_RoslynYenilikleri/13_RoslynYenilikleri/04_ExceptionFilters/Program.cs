using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("Validasyon Hatası"); 
                //throw new Exception("Uyarı"); 
                //throw new Exception("Sistem Hatası"); 
            }
            catch (Exception ex) when (ex.Message == "Validasyon Hatası")
            {
                Console.WriteLine("Catch Blok-1: " + ex.Message);
            }

            catch (Exception ex) when (ex.Message == "Uyarı")
            {
                Console.WriteLine("Catch Blok-2: " + ex.Message);
            }
            catch (Exception ex) when (ex.Message == "Sistem Hatası")
            {
                Console.WriteLine("Catch Blok-3: " + ex.Message);
            }


            Console.ReadKey();
        }
    }
}
