using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_FontDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFontDuzenle_Click(object sender, EventArgs e)
        {
            //fontdialog üzerinden bazı özelliklerin limitlerini kısıtlayabiliriz.
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = false;
            fontDialog1.MaxSize = 20;
            fontDialog1.MinSize = 12;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //fontdialog üzerinden seçilen font ve renk bilgilerini textbox'a uyguluyoruz.
                txtWord.Font = fontDialog1.Font;
                txtWord.ForeColor = fontDialog1.Color;
            }
        }
    }
}
