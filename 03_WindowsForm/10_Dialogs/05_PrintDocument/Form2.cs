using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_PrintDocument
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Preview'ın hangi document nesnesini göstereceğiniz belirtiyoruz.
            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, 40, 40, 100, 100);

            Font font = new Font("Calibri", 30, FontStyle.Bold);
            e.Graphics.DrawString("YAZILIM SINIFI", font, Brushes.Red, 150, 40);
        }
    }
}
