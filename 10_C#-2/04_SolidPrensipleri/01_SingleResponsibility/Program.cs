using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingleResponsibility
{
    //(S)ingle Responsibility Principle
    //Her sınıfın veya methodun tek bir sorumluğuğu olmalıdır!

    //(O)pen/Closed Principle
    //(L)iskov's Substitution Principle
    //(I)nterface Segragation Principle
    //(D)ependency Inversion Principle

    class Program
    {
        static void Main(string[] args)
        {
            UserBusiness userBusiness = new UserBusiness();
            userBusiness.UpdateUser("Ali", "Beşiktaş");

            Console.ReadKey();
        }
    }
}
