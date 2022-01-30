using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_TextControls
{
    public partial class Form1 : Form
    {
        static List<string> ogrenciler = new List<string>
        {
            "Rüştü",
            "Berat",
            "Utku",
            "Ömer",
            "Halil İbrahim",
            "Bahadır"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sonuc = Convert.ToInt32(txtSayi1.Text) + Convert.ToInt32(txtSayi2.Text);
            MessageBox.Show(sonuc.ToString());
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            int sonuc = Convert.ToInt32(txtCikarmaSayi1.Text) - Convert.ToInt32(txtCikarmaSayi2.Text);
            MessageBox.Show(sonuc.ToString());
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            int sonuc = Convert.ToInt32(txtCarpmaSayi1.Text) * Convert.ToInt32(txtCarpmaSayi2.Text);
            MessageBox.Show(sonuc.ToString());
        }

        private void Bölme_Click(object sender, EventArgs e)
        {
            int sonuc = Convert.ToInt32(txtBolmeSayi1.Text) / Convert.ToInt32(txtBolmeSayi2.Text);
            MessageBox.Show(sonuc.ToString());
        }

        private void txtArama1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txtArama1.Text);
        }

        private void txtArama2_TextChanged(object sender, EventArgs e)
        {
            if (txtArama2.Text.Length <= 3)
            {
                lblSonuclar.Text = "Hiç sonuç bulunamadı...";
                return;
            }

            lblSonuclar.Text = "";

            foreach (var ogrenci in ogrenciler)
            {
                if (txtArama2.Text == string.Empty)
                {
                    lblSonuclar.Text = "Hiç sonuç bulunamadı...";
                }
                else if (ogrenci.Contains(txtArama2.Text))
                {
                    lblSonuclar.Text += ogrenci + "\r\n";
                }
            }
        }
    }
}
