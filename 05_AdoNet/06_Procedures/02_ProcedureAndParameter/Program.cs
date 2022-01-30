using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ProcedureAndParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("data source=LENOVO-PC\\SQLEXPRESS;initial catalog=NORTHWND;integrated security=true;");

            SqlCommand cmd = new SqlCommand("GetOrderByCustomerId", con)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            //Bir procedure execute edilirken, eklenen parametreler ile sql'de tanımlanan parametre isimleri birebir aynı olmak zorundadır.
            //Aşağıdaki parametre eklenirken parametre adına @customerId yazmasaydık çalışma zamanında hata alacaktık.
            cmd.Parameters.AddWithValue("@customerId", "CACTU");

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //GetName methodu, kolon index2ini vererek kolonun adını almamızı sağlar.
                Console.WriteLine("{0} : {1}", dr.GetName(0), dr[0]);

                //1 index'li kolonun adıyla birlikte değerini yanyana yazdırdık.
                Console.WriteLine("{0} : {1}", dr.GetName(1), dr[1]);

                Console.WriteLine("**********************************************");
            }

            con.Close();

            Console.ReadKey();
        }
    }
}
