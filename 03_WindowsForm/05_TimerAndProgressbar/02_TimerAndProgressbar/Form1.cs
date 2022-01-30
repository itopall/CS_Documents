using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_TimerAndProgressbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgKopyalama.Increment(1);

            lblYuzde.Text = "%" + pgKopyalama.Value.ToString();

            if (pgKopyalama.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Kopyalama tamamlanmıştır...");
            }
        }
    }
}
