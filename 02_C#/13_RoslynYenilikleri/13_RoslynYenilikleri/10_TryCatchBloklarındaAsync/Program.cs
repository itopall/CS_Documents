using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_TryCatchBloklarındaAsync
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.ReadKey();
        }

        //try-catch bloklarında async await keyword'leri ile asenkron methodlar yazabiliriz.
        private static async void TestMethod()
        {
            try
            {
                Console.WriteLine("try içerisine girildi...");
                throw new Exception("Hata oluştu!");
            }
            catch (Exception ex)
            {
                await TestMethod2();
            }
            finally
            {
                await TestMethod3();
            }
        }
        private static async Task TestMethod2()
        {
            Console.WriteLine("async testmethod2 tetiklendi");
        }
        private static async Task TestMethod3()
        {
            Console.WriteLine("async testmethod3 tetiklendi");
        }
    }
}
