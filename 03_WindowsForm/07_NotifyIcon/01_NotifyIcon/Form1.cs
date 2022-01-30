using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_NotifyIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright 2020 Tüm Hakları saklıdır. Versiyon 1.0.0");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close();
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            MessageBox.Show("NotifyIcon çift tıklandı.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //NotifyIcon.Visible true yapılırsa sağ alt koşede görünür aksi halde false olursa notifyIcon sağ alt köşede görünmeyecektir.
            notifyIcon1.Visible = true;
        }
    }
}
