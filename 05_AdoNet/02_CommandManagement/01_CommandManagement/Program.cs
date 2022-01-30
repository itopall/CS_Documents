using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CommandManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(@"data source=LENOVO-PC\SQLEXPRESS; initial catalog=NORTHWND; integrated security=true;");

            #region ExecuteNonQuery
            //Create, Alter, Drop, Insert, Update, Delete işlemleri için kullanılır.
            conn.Open();

            //Insert İşlemi
            //SqlCommand cmd = new SqlCommand("INSERT INTO AdoNetTest VALUES ('Test')", conn);
            //cmd.ExecuteNonQuery();

            //Update İşlemi
            //SqlCommand cmd = new SqlCommand("UPDATE AdoNetTest SET Name = 'Deneme' WHERE Id = 1", conn);
            //cmd.ExecuteNonQuery();

            //Delete İşlemi
            //SqlCommand cmd = new SqlCommand("DELETE FROM AdoNetTest WHERE Id = 1", conn);
            //cmd.ExecuteNonQuery();

            //Alter İşlemi
            //SqlCommand cmd = new SqlCommand("ALTER TABLE AdoNetTest ALTER COLUMN Name NVARCHAR(1000) NULL", conn);
            //cmd.ExecuteNonQuery();

            //Drop İşlemi
            //SqlCommand cmd = new SqlCommand("DROP TABLE AdoNetTest", conn);
            //cmd.ExecuteNonQuery();

            conn.Close();
            #endregion

            #region ExecuteScalar
            //Db'den int, string gibi value type'lı bir değer çekmek için kullanılır.
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Products", conn);

            int count = (int)cmd.ExecuteScalar();
            Console.WriteLine("Ürün sayısı: {0}", count);

            conn.Close();
            #endregion

            #region ExecuteReader
            //Bir resultset içindeki verilerin tamamını okumak için kullanılır.

            //Bir komutu oluşturmanın en kısa yolu
            //SqlCommand cmd2 = new SqlCommand("SELECT * FROM Products", conn);

            //Üst satırdakiyle aynı işi yapar.
            SqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = "SELECT * FROM Products";

            conn.Open();

            SqlDataReader dr = cmd2.ExecuteReader();

            dr.Read(); //1. satırın okunmasını sağlar
            Console.WriteLine(dr[1]);
            dr.Read(); //2. satırın okunmasını sağlar
            Console.WriteLine(dr[1]);

            //Read methodu kayıt kalmadığında false döner, böylelikle while döngüsü kayıt geldiği sürece dönmeye devam eder.
            while (dr.Read())
            {
                Console.WriteLine();
                Console.WriteLine(dr["ProductId"] + " || " + dr["ProductName"]);
            }

            //Datareader'ın işi bittiğinde kapatılmalıdır.
            dr.Close();

            //Eğer bir bağlantı kapatılıyorsa o bağlantı üzerindeki bütün datareader'lar kapatılır! Üst satırda SqlDataReader kapatılmasaydı otomatik kapatılacaktı.
            conn.Close();
            #endregion

            #region SqlParameter
            Console.Write("İsim giriniz: ");
            string name = Console.ReadLine();

            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE FirstName = @FirstName", conn);

            //Yöntem 1: Tek tek SqlPArameter nesneleri oluşturarak command'a ekleyebilir.z
            //SqlParameter p1 = new SqlParameter("@FirstName", name);
            //cmd3.Parameters.Add(p1);

            //Yöntem 2: Yukarıdaki ile aynı anlamı taşıyan Parameters.AddWithValue methodu ekleyebiliriz.
            //Sql Parameter kullanımı ile injection saldırılarının önüne geçilir. Çünkü kullanıcının yazdığı değerler direkt olarak sorgunun içerisinde kullanılmaz.
            cmd3.Parameters.AddWithValue("@FirstName", name);

            conn.Open();

            if ((int)cmd3.ExecuteScalar() > 0)
                Console.WriteLine("Hoşgeldiniz {0}", name);
            else
                Console.WriteLine("Girdiğiniz isim hatalı");

            conn.Close();
            #endregion

            //Ödev: Windows form uygulaması içerisinde ekrana bir tane combobox koyalım ve db'deki Categories tablosunda bulunan bütün kategorileri combobox'da listeleyelim.

            Console.ReadKey();
        }
    }
}
