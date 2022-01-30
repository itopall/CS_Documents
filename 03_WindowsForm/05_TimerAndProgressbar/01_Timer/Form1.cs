using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Timer arkaplanda tekrar eden işlemler kurgulamak için kullanılan bir yapıdır. Tick event2i içerisinde yapılmak istenen işlemler yapılabilir.
        //Interval property'si timer'ın kaç milisaniyede bir tetikleneceğini belirler.

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //timer1.Enabled = true; //Üstteki satırlar aynı işi yapar
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //timer1.Enabled = false; //Üstteki satırlar aynı işi yapar

            MessageBox.Show(lstKelimeler.Items.Count + " adet kelime eklendi!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lstKelimeler.Items.Add("Test");
        }
    }
}
