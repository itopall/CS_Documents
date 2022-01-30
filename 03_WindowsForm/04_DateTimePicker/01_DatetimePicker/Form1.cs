using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_DatetimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başlangıç Tarihi: " + dtpBaslangicTarihi.Value);
            MessageBox.Show("Bitiş Tarihi: " + dtpBitisTarihi.Value);

            MessageBox.Show("Aradaki gün sayısı: " + (dtpBitisTarihi.Value - dtpBaslangicTarihi.Value).Days);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Formun açılışında bitiş tarihini ayarlıyoruz.
            dtpBitisTarihi.Value = DateTime.Now.AddDays(5);

            //Bugünden eski tarihlerin görünmesini istemiyorsak aşağıdaki şekilde kapatabiliriz.
            dtpBaslangicTarihi.MinDate = DateTime.Now;
        }

        private void dtpBaslangicTarihi_ValueChanged(object sender, EventArgs e)
        {
            //Tatil sitelerinde olduğu gibi başlangıç tarihi her değiştiğinde bitiş tarihi değerini, başlangıçtan 5 gün sonra olacak şekilde ayarlıyoruz.
            if (dtpBaslangicTarihi.Value < DateTime.Now)
            {
                MessageBox.Show("Başlangıç tarihi bugünden küçük olamaz!");
                dtpBaslangicTarihi.Value = DateTime.Now;
            }

            dtpBitisTarihi.Value = dtpBaslangicTarihi.Value.AddDays(5);
        }

        private void dtpBitisTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBitisTarihi.Value < dtpBaslangicTarihi.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden küçük olamaz!");
                dtpBitisTarihi.Value = dtpBaslangicTarihi.Value.AddDays(5);
            }
        }
    }
}
