using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Layout
{
    public partial class Form1 : Form
    {
        //Layout mantığı bir form şablonu oluşturmak için kullanılır. Proje geliştirirken belli bir format belirlenip bütün formların benzer özelliklerde olması ve standart olması proje açısından önemli bir konudur.
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Ürünler";
            lblOzet.Text = "Sistemdeki ürünleri buradan yönetebilirsiniz.";

            //Ürünler panel'i ekranda gösterildi diğer hepsi kapatıldı.
            pnlUrun.Visible = true;
            pnlSatislar.Visible = false;
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Satışlar";
            lblOzet.Text = "Sistemdeki satışları buradan yönetebilirsiniz.";

            //Satışlar panel'i ekranda gösterildi diğer hepsi kapatıldı.
            pnlUrun.Visible = false;
            pnlSatislar.Visible = true;
        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Stoklar";
            lblOzet.Text = "Sistemdeki stokları buradan yönetebilirsiniz.";
        }

        private void btnYetkiler_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Yetkiler";
            lblOzet.Text = "Sistemdeki yetkileri buradan yönetebilirsiniz.";
        }

        private void btnSatisRaporu_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Satış Raporu";
            lblOzet.Text = "Satış raporunu buradan yönetebilirsiniz.";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Formun açılışında görünmesinler
            pnlUrun.Visible = false;
            pnlSatislar.Visible = false;

            //Panellerin ekranda görünecekleri yeri default olarak ayarlıyoruz. Böylelikle kayma olmayacak
            pnlUrun.Location = new Point(187, 27);
            pnlSatislar.Location = new Point(187, 27);
        }
    }
}
