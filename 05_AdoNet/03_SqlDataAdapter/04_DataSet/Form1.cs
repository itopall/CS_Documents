using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataSet, içinde birden fazla datatable'ın referansını tutarak, bu tabloların arasındaki ilişkileri sağlar.
            //Bir komut nesnesinin commandText'ine aşağıdaki gibi birden fazla result döndüren bir komut da yazılabilir.
            SqlConnection con = new SqlConnection("data source=LENOVO-PC\\SQLEXPRESS;initial catalog=NORTHWND;integrated security=true;");

            DataSet ds = new DataSet("Northwnd");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Products; SELECT * FROM Categories", con);

            sda.TableMappings.Add("Table", "Products");
            sda.TableMappings.Add("Table1", "Categories");

            sda.Fill(ds);

            comboBox1.DisplayMember = "TableName";
            comboBox1.DataSource = ds.Tables.Cast<DataTable>().ToArray();

            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combobox'a datasource olarak DataTable'ı verdik! Bu durumda combobox1 içindeki her bir eleman birer DataTable olacaktır. Dolayısıyla combobox1.SelectedItem denilerek, seçili eleman okunduğunda, bize seçili DataTable nesnesi gelecektir.
            dataGridView1.DataSource = comboBox1.SelectedItem;
        }
    }
}
