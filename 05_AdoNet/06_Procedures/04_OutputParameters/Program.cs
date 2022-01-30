using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OutputParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("data source=LENOVO-PC\\SQLEXPRESS;initial catalog=NORTHWND;integrated security=true;");

            SqlCommand cmd = new SqlCommand("ProductInformation", con)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            //Input parametreler eklenirken değerleriyle birlikte eklenirler!
            //cmd.Parameters.AddWithValue("@CategoryId", 1);

            //Komut parametresinde tanımlanan her bir parametre bir SqlParameter nesnesidir.
            //Bir SqlParameter nesnesi, üzerinde tip bilgisini de barındırır.
            //Input parametreler değerleri ile birlikte gönderildikleri için tip bilgisi otomatik olarak gelen değerden elde edilir. Yukarıda @CategoryId için 1 değeri gönderildiğinden tip otomatik olarak SqlDbType.Int olur

            //Ancak ıutput parametrelerde değer gönderilmediği için tip bilgisi belirtilmelidir.

            SqlParameter p1 = new SqlParameter("@productCount", SqlDbType.Int);
            p1.Direction = ParameterDirection.Output; //Proc'da output olarak tanımlanmışsa bu şekilde output olarak göndermemiz gerekir.

            SqlParameter p2 = new SqlParameter("@sumPrice", SqlDbType.Int);
            p2.Direction = ParameterDirection.Output;

            SqlParameter p3 = new SqlParameter("@average", SqlDbType.Int);
            p3.Direction = ParameterDirection.Output;

            SqlParameter p4 = new SqlParameter("@note", SqlDbType.NVarChar, 100);
            p4.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            //Add methodu oluşturduğu SqlParameter nesnesini geri döner! Dolayısıyla Add methodundan sonra "." operatörüyle üyelere erişilirse SqlParameter nesnesinin üyeleri çıkar.
            //cmd.Parameters.Add("@productCount", SqlDbType.Int).Direction = ParameterDirection.Output;

            con.Open();

            cmd.ExecuteNonQuery(); //Bu procedure geriye result set dönmez! Yalnızca output parametrelere set edilirler

            Console.WriteLine("ProductCount: {0}", p1.Value); //cmd.Parameters[0].Value
            Console.WriteLine("sumPrice: {0}", p2.Value);
            Console.WriteLine("average: {0}", p3.Value);
            Console.WriteLine("note: {0}", p4.Value);

            con.Close();

            Console.ReadKey();
        }
    }
}
