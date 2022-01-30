using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("data source=LENOVO-PC\\SQLEXPRESS;initial catalog=NORTHWND;integrated security=true;");

            SqlCommand cmd = new SqlCommand("ProductCount2", con)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@productCount", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            Console.WriteLine("Productcount: {0}", cmd.Parameters["@productCount"].Value);

            Console.ReadKey();
        }
    }
}
