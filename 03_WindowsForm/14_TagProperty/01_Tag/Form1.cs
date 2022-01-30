using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Tag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRenkAyarla.Tag = Color.Blue;
            btnMesajVer.Tag = "Nasa'nın giriş kodları: 12334985734876123";
        }

        //Tag property'si gizli bir alan gibi arkaplanda o kontrol üzerinde (button, textbox vs.) bilgi saklayabilmemize olanak sağlar.
        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            textBox1.Text = btnMesajVer.Tag.ToString();
        }

        private void btnRenkAyarla_Click(object sender, EventArgs e)
        {
            this.BackColor = (Color)btnRenkAyarla.Tag;
        }
    }
}
