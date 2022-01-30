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

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U5C8MCU\SQLEXPRESS; initial catalog=NORTHWND; integrated security=true;");

            SqlCommand cmd = new SqlCommand("SELECT *FROM Categories",conn);

            conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CategoryId"]);
                comboBox2.Items.Add(dr["CategoryName"]);
                comboBox3.Items.Add(dr["Description"]);
                
            }
            

            dr.Close();

            conn.Close();
        }
    }
}
