using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_ContextMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (aynıKayıtTekrarGirilemesinToolStripMenuItem.Checked && lstUrunler.Items.Contains(txtUrun.Text))
            {
                MessageBox.Show("Bu kayıt daha önce girilmiş, tekrar girilemez!");
                return;
            }

            lstUrunler.Items.Add(txtUrun.Text);
        }

        private void seçileniSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (lstUrunler.SelectedItem != null)
            //    lstUrunler.Items.Remove(lstUrunler.SelectedItem);
            //else
            //    MessageBox.Show("Lütfen önce bir kayıt seçiniz!");

            if (lstUrunler.SelectedIndex != -1)
                lstUrunler.Items.RemoveAt(lstUrunler.SelectedIndex);
            else
                MessageBox.Show("Lütfen önce bir kayıt seçiniz!");
        }

        private void tümünüSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstUrunler.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Listbox'a sağ tıkladığımızda açılmasını istediğimiz context menuyü bağlıyoruz.
            lstUrunler.ContextMenuStrip = contextMenuStrip1;

            //MenuItem nesnesinin checkbox gibi davranmasını sağlar.
            aynıKayıtTekrarGirilemesinToolStripMenuItem.CheckOnClick = true;

            DinamikMenuOlustur();
        }

        private void DinamikMenuOlustur()
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            //Seçenek 1
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem();
            menuItem1.Text = "Arka plan rengini değiştir.";
            menuItem1.Click += new EventHandler(menuItem1_Click);
            menu.Items.Add(menuItem1);

            //Seçenek 2
            ToolStripMenuItem menuItem2 = new ToolStripMenuItem();
            menuItem2.Text = "Kapat";
            menuItem2.Click += (sender, e) =>
            {
                Close();
            };
            menu.Items.Add(menuItem2);

            //Seçenek 3
            ToolStripMenuItem menuItem3 = new ToolStripMenuItem();
            menu.Items.Add(menuItem3);

            //Seçenek 4
            ToolStripMenuItem menuItem4 = new ToolStripMenuItem();
            menuItem4.Text = "Mesaj Ver";
            menuItem4.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Dinamil oluşturulan menuItem tıklandı.");
            };
            menu.Items.Add(menuItem4);


            this.ContextMenuStrip = menu;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("menuItem1_Click tetiklendi!");
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }
    }
}
