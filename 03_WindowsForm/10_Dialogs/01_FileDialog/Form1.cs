using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_FileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Sadece txt dosyaların listelenmesini sağlıyoruz.
            openFileDialog1.Filter = "Metin Dosyası | *.txt";

            //İşletim sisteminin dosya açma popup penceresinin açılmasını sağlıyoruz.
            DialogResult result = openFileDialog1.ShowDialog();

            //Eğer açılan popup ekranından bir dosya seçilip Tamam butonuna basılmışsa bu if bloğunun içerisine girilecektir. İçeride ise dosyanın içeriğini okuyup textbox'a aktarıyoruz.
            if (result == DialogResult.OK)
            {
                txtWord.Text = File.ReadAllText(openFileDialog1.FileName);
                MessageBox.Show("Uzunluk: " + txtWord.Text.Length);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyası | *.txt";

            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtWord.Text);
                MessageBox.Show("Dosya başarıyla kaydedildi. Uzunluk: " + txtWord.Text.Length + "\r\nLokasyon: " + saveFileDialog1.FileName);
            }
        }
    }
}
