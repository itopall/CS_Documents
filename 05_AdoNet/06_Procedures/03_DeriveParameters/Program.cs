using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DeriveParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //DeriveParameters: Bir procedure'ün parametre listesinin serverdan alınarak Command'a doldurulmasını sağlar.
            SqlConnection con = new SqlConnection("data source=LENOVO-PC\\SQLEXPRESS;initial catalog=NORTHWND;integrated security=true;");

            SqlCommand cmd = new SqlCommand("UpdateProductPrice", con)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            con.Open();

            //DeriveParameters methodu açık ve kullanılabilir bir bağlantıya ihtiyaç duyar
            SqlCommandBuilder.DeriveParameters(cmd);

            cmd.Parameters[1].Value = 1;
            cmd.Parameters[2].Value = 60;

            Console.WriteLine("Kayıt güncellendi", cmd.ExecuteNonQuery());

            con.Close();

            Console.ReadKey();
        }
    }
}
