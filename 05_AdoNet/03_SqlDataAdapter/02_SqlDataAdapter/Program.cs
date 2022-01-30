using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SqlDataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("data source=LENOVO-PC\\SQLEXPRESS;initial catalog=NORTHWND;integrated security=true;");

            //Bir DataTable'a products tablosundaki kayıtları dolduralım.
            DataTable dt = new DataTable("Products");

            //SqlCommand'da olduğu gibi SqlDataAdapter içerisinde de sorguyu yazıp connection nesnesini belirtiyoruz.
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Products", con);

            //Fill methodu şemayı otomatik olarak oluşturur ve verileri DataTable'a DataRow nesneleri halinde ekler.
            sda.Fill(dt);

            //DataAdapter, Fill işlemi sırasında bağlantı açma kapama işlemlerini kendisi gerçekleştirir. Adapter yalnızca verilerin DataTable'a eklenmesi için değil, eklenen veriler üzerinden yapılan değişikliklerin tekrar veri kaynağına yansıtılması için de kullanılır.

            foreach (DataRow dr in dt.Rows)
                Console.WriteLine($"{dr["ProductId"]} - {dr["ProductName"]} - {dr["UnitPrice"]}");

            Console.ReadKey();
        }
    }
}
