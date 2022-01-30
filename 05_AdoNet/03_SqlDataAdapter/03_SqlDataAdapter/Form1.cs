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

namespace _03_SqlDataAdapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlConnection con = new SqlConnection("data source=LENOVO-PC\\SQLEXPRESS;initial catalog=NORTHWND;integrated security=true;");

            DataTable dt = new DataTable("Products");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Products", con);

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
