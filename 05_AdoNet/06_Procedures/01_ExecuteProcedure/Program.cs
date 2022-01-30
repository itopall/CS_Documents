using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ExecuteProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("data source=LENOVO-PC\\SQLEXPRESS;initial catalog=NORTHWND;integrated security=true;");

            //Normal sorgudan tek farkı CommandType'ı StoredProcedure olarak ayarlamaktır. Geriye kalan adımlar aynı mantıkla uygulanabilir.
            SqlCommand cmd = new SqlCommand("AllProducts", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            //Sadece ProductId ve ProductName değerlerini yanyana ekrana yazdırdık.
            while (dr.Read())
            {
                Console.WriteLine(dr["ProductId"] + " || " + dr["ProductName"]);
            }

            con.Close();

            Console.ReadKey();
        }
    }
}
