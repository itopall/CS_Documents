using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_OwnerForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblOwnerVarMi.Text = this.Owner != null ? Owner.Name : "Sahip Yok";
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            ((Form1)Owner).HareketEttir(-5);
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            ((Form1)Owner).HareketEttir(5);
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            ((Form1)Owner).YanaHareketEttir(-5);
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            ((Form1)Owner).YanaHareketEttir(5);
        }

        private void txtGelenMesaj_TextChanged(object sender, EventArgs e)
        {
            ((Form1)Owner).Mesaj = txtGelenMesaj.Text;
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            #region 1. Yöntem
            //txtGelenMesaj.Text = ((Form1)Owner).Mesaj;
            #endregion

            #region 2. Yöntem
            //TextBox txt = (TextBox)Owner.Controls["txtGidenMesaj"];
            //txtGelenMesaj.Text = txt.Text;
            #endregion

            #region 3. Yöntem
            txtGelenMesaj.Text = ((Form1)Owner).txtGidenMesaj.Text;
            #endregion

            #region 3. Yöntemin Sonuçları
            TextBox txt = ((Form1)Owner).txtGidenMesaj;
            txt.Width = 300;
            txt.Height = 50;
            txt.BackColor = Color.Blue;
            txt.Font = new Font("Verdana", 22);
            txtGelenMesaj.Text = txt.Text;
            #endregion
        }
    }
}
