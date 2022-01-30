using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKelimeler.Items.Add("IPhone X");
            cmbKelimeler.Items.Add("Samsung Galaxy");

            //Combobox'a text yazılmasını engellemek için List modunda çalıştırdık.
            cmbKelimeler.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKelime.Text))
            {
                MessageBox.Show("Lütfen önce bir kelime yazınız!");
                return;
            }

            cmbKelimeler.Items.Add(txtKelime.Text);

            MessageBox.Show(txtKelime.Text + " başarıyla eklendi...");
            txtKelime.Text = "";
        }

        private void btnSecileniGoster_Click(object sender, EventArgs e)
        {
            if (checkSelectedItem())
                MessageBox.Show(cmbKelimeler.SelectedItem.ToString());
        }

        private bool checkSelectedItem()
        {
            if (cmbKelimeler.SelectedItem != null)
                return true;

            MessageBox.Show("Lütfen önce listeden bir değer seçiniz!");
            return false;
        }

        private void cmbKelimeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkSelectedItem())
                txtKelime.Text = cmbKelimeler.SelectedItem.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (checkSelectedItem())
                cmbKelimeler.Items[cmbKelimeler.SelectedIndex] = txtKelime.Text;
        }

        private void btnSecileniSil_Click(object sender, EventArgs e)
        {
            if (checkSelectedItem())
                cmbKelimeler.Items.Remove(cmbKelimeler.SelectedItem);
        }
    }
}
