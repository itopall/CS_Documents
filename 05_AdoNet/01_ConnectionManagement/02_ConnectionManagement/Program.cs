using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ConnectionManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["Northwnd_connStr"];

            SqlConnection conn = new SqlConnection(settings.ConnectionString);
            conn.Open();

            Console.WriteLine("Durum: {0}", conn.State);
            Console.WriteLine("Veritabanı: {0}", conn.Database);
            Console.WriteLine("Sunucu: {0}", conn.DataSource);
            Console.WriteLine("Sql Server Versiyonu: {0}", conn.ServerVersion);

            conn.Close();
            Console.WriteLine("Durum: {0}", conn.State);

            Console.ReadKey();
        }
    }
}
