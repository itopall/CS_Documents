using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormEventKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnMesajVer butonu için yeni bir event yazıldı.");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnKapat butonu tıklandı! Ekran şimdi kapanacak.");
            Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnTest event'i tetiklenecek");
            
        }
    }
}
