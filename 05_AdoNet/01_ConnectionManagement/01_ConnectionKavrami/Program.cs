using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConnectionKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Connection Kavramı
            DbConnection dbConnection;

            dbConnection = new SqlConnection();
            dbConnection = new OleDbConnection();

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = @"data source=LENOVO-PC\SQLEXPRESS; initial catalog=NORTHWND; integrated security=true;";
            connection.ConnectionString = @"server=LENOVO-PC\SQLEXPRESS; database=NORTHWND; integrated security=SSPI;";
            #endregion

            SqlConnection conn = new SqlConnection(@"data source=LENOVO-PC\SQLEXPRESS; initial catalog=NORTHWND; integrated security=true;");

            //Öncelikle Open methodu ile bağlantının açılması gerekir.
            conn.Open();

            SqlCommand cmd = new SqlCommand("CREATE TABLE AdoNetTest (Id INT PRIMARY KEY Identity(1,1), Name NVARCHAR(100))", conn);

            int result = cmd.ExecuteNonQuery();
            Console.WriteLine(result);

            //İşimiz bittiğinde bağlantıyı kapatmamız gerekir.
            conn.Close();

            Console.ReadKey();
        }
    }
}
