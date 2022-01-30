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

namespace _03_SqlDataAdapter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //Eğer datatable'dan gelen bütün sütunların grid'in içerisinde görünmesini istemiyorsak sadece bir kaç tane sütunun görünmesini istiyorsak AutoGeneratecolumns özelliğini false olarak belirleyip Grid'in üzerinden Add Columns özelliği ile görüntülemek istediğimiz sütunları tek tek belirtebiliriz.
            //DataSource Bağlanmadan Önce bu işlem yapılmalı!
            dataGridView1.AutoGenerateColumns = false;

            SqlConnection con = new SqlConnection("data source=LENOVO-PC\\SQLEXPRESS;initial catalog=NORTHWND;integrated security=true;");

            DataTable dt = new DataTable("Products");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Products", con);

            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            //DataView Kullanımı - 1.Yöntem
            //DataView view = new DataView(dt);
            //view.RowFilter = "UnitPrice > 30 AND UnitPrice < 100";
            //view.Sort = "ProductId DESC";
            //dataGridView1.DataSource = view;

            //DataView Kullanımı - 2.Yöntem
            DataView view2 = new DataView(dt, "UnitPrice > 30 AND UnitPrice < 100", "ProductName ASC", DataViewRowState.CurrentRows);
            dataGridView1.DataSource = view2;
        }
    }
}
