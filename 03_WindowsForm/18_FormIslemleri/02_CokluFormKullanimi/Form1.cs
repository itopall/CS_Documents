using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_CokluFormKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.FormClosed += new FormClosedEventHandler(Form_Closed); //Form_Closed;
            form.Show();
        }

        void Form_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("Form_Closed tetiklendi...");
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product form = new Product();
            //form.Show(); //Modeless görüntüleme

            //Modal genelde görüntülemedir. Modal görüntülenen form kapatılmadan diğer formlar kullanılamaz! Dialog pencereleri bu şekilde Modal olarak görüntülenirler.
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Ana form kapanır Run methodu sonlanır, Run methodu sonlandığında Main sonlanır böylece program sonlanmış olur.
            Close();
        }
    }
}
