using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_MdiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.MdiParent = this;
            urunler.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1'i Mdi container haline getirdik. Diğer formlar bu formun içerisinde gömülü olarak gelecek.
            IsMdiContainer = true;
        }
    }
}
