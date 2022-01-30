using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Transaction
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("data source=LENOVO-PC\\SQLEXPRESS;initial catalog=NORTHWND;integrated security=true;");

            SqlCommand cmd1 = new SqlCommand("INSERT INTO Orders (CustomerId, EmployeeId) VALUES ('ALFKI', 1)", con);

            SqlCommand cmd2 = new SqlCommand("INSERT INTO [Order Details] VALUES (10248, 3, 10, 1, 0)", con);

            con.Open();

            //BeginTransaction için açık bir bağlantıya ihtiyaç vardır.
            //BeginTransaction methoduyla SqlTransaction nesnesi elde edilir.
            SqlTransaction transaction = con.BeginTransaction();

            //Bu iki komutun aynı transaction'da bulunacağını, ikisine de aynı SqlTransaction nesnesini vererek belirttik.
            cmd1.Transaction = transaction;
            cmd2.Transaction = transaction;

            try
            {
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                transaction.Commit();

                Console.WriteLine("Satış işlemi başarıyla gerçekleştirildi.");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }

            //Stock kontrol trigger'ı çalıştığı için Order Detail tablosuna Insert'de hata aldık. Trigger'ı disable etmek için aşağıdaki sorgu kullanılabilir.
            //ALTER TABLE[Order Details] DISABLE TRIGGER DecreaseStock

            con.Close();

            Console.ReadKey();
        }
    }
}
