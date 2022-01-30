using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employees classından e adında bir nesne yarattık.
            Employees e = new Employees();
            //bu e nesnesinden, class içerisindeki propertylere ulaştık.
            e.EmployeeId1 = 1;//set methodunu çalıştırmış olduk.
            Console.WriteLine("Kullanıcı Id: {0}",e.EmployeeId1);//encapsulation içerisindeki get methodu çalışır.
            Console.WriteLine("Personel adı:{0}",e.FirstName1);//sadece get methodu olduğundan dışarıdan değer girilemez.
            e.LastName1 = "Topal";//okuma değeri olmadığından sadece set edebiliyoruz.
            e.Title1 = "yazılım geliştirici";
            Console.WriteLine(e.Title1);
            e.DepartmentName1 = "Yazılım departmanı";
            Console.WriteLine(e.DepartmentName1);

            Console.ReadKey();
        }
    }
}
