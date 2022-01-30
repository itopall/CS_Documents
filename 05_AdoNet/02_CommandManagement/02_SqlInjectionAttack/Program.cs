using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SqlInjectionAttack
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(@"data source=LENOVO-PC\SQLEXPRESS; initial catalog=NORTHWND; integrated security=true;");

            Console.Write("İsim giriniz: ");
            string name = Console.ReadLine();

            //Sql injection saldırısının gerçekleşebilmesi için, sql command'ın WHERE kısmına kullanıcıdan istenenparametrelerin direkt olarak eklenmesi gerekir.

            //HATALI KULLANIM
            //string comandText = string.Format("SELECT COUNT(*) FROM Employees WHERE FirstName = '{0}'", name);

            //SqlCommand cmd = new SqlCommand(comandText, conn);

            //DOĞRU KULLANIM
            string comandText = "SELECT COUNT(*) FROM Employees WHERE FirstName = @FirtName";
            SqlCommand cmd = new SqlCommand(comandText, conn);
            cmd.Parameters.AddWithValue("@FirtName", name);

            conn.Open();

            if ((int)cmd.ExecuteScalar() > 0)
                Console.WriteLine("Hoşgeldiniz " + name);
            else
                Console.WriteLine("İsminizi hatalı girdiniz!");

            Console.ReadKey();
        }
    }
}
