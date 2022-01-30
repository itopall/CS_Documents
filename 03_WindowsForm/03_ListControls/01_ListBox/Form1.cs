using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Formun açılışında çalışacak olan Event'dir. Formun çalışmasında kullanılacak bazı değişken tanımlamaları, instance alma, default değer atamaları, background color gibi tasarım işlemleri burada yapılabilir.
        private void Form1_Load(object sender, EventArgs e)
        {
            lstKelimeler.Items.Add("Kasa");
            lstKelimeler.Items.Add("Masa");

            btnGuncelle.Enabled = false;
            btnSecileniGoster.Enabled = false;
            btnSecileniSil.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKelime.Text))
            {
                MessageBox.Show("Eklemek için bir değer giriniz!");
                return;
            }

            lstKelimeler.Items.Add(txtKelime.Text);
            txtKelime.Text = "";
        }

        private void btnSecileniGoster_Click(object sender, EventArgs e)
        {
            //Eğer listeden hiç bir değer seçilmemişse SelectedIndex değeri -1 gelir. Aşağıdaki kod bloğunda Items'ın içerisinde -1 olmadığı için hata alır. O yüzden bu tarz işlemlerde validasyon uygulamak son derece önemlidir.

            //1. Yöntem
            //if (lstKelimeler.SelectedIndex > -1)
            //    MessageBox.Show(lstKelimeler.Items[lstKelimeler.SelectedIndex].ToString());
            //else
            //    MessageBox.Show("Lütfen önce listeden bir değer seçiniz!");

            //2. Yöntem
            if (lstKelimeler.SelectedItem != null)
                MessageBox.Show(lstKelimeler.SelectedItem.ToString());
            else
                MessageBox.Show("Lütfen önce listeden bir değer seçiniz!");
        }

        //SelectedIndexChanged event'i listedeki elemanlar içerisinde seçili olanın değiştirilmesi sonucunda tetiklenir. Update işlemi için seçili olan değeri yakalayıp kullanabiliriz.
        private void lstKelimeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listeden seçilen elemanı bulup güncellemek üzere textbox'a yazıyoruz.

            //1. Yöntem
            //if (lstKelimeler.SelectedIndex > -1)
            //    txtKelime.Text = lstKelimeler.Items[lstKelimeler.SelectedIndex].ToString();

            //2. Yöntem
            if (lstKelimeler.SelectedItem != null)
            {
                txtKelime.Text = lstKelimeler.SelectedItem.ToString();

                //Eğer listeden bir eleman seçilmişse bu butonları aktif hale getiriyoruz.
                btnGuncelle.Enabled = true;
                btnSecileniGoster.Enabled = true;
                btnSecileniSil.Enabled = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Güncel değeri listbox'daki ilgili index'e yeni haliyle tekrar aktardık.

            if (lstKelimeler.SelectedIndex > -1)
            {
                if (string.IsNullOrEmpty(txtKelime.Text))
                {
                    MessageBox.Show("Güncellemek için bir değer giriniz!");
                    return;
                }

                lstKelimeler.Items[lstKelimeler.SelectedIndex] = txtKelime.Text;
            }
            else
                MessageBox.Show("Lütfen önce listeden bir değer seçiniz!");
        }

        private void btnSecileniSil_Click(object sender, EventArgs e)
        {
            //1. Yöntem
            //if (lstKelimeler.SelectedIndex > -1)
            //    lstKelimeler.Items.RemoveAt(lstKelimeler.SelectedIndex);
            //else
            //    MessageBox.Show("Lütfen önce listeden bir değer seçiniz!");

            //2. Yöndem
            if (lstKelimeler.SelectedItem != null)
                lstKelimeler.Items.Remove(lstKelimeler.SelectedItem);
            else
                MessageBox.Show("Lütfen önce listeden bir değer seçiniz!");
        }
    }
}
