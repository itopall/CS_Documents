using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_FormEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Load tetiklendi...");
            //MessageBox.Show("Load tetiklendi...");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Debug.WriteLine("Paint tetiklendi...");
            //MessageBox.Show("Paint tetiklendi...");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Debug.WriteLine("Activeted tetiklendi...");
            //MessageBox.Show("Activeted tetiklendi...");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Debug.WriteLine("DeActivete tetiklendi...");
            //MessageBox.Show("DeActivete tetiklendi...");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form kapatılırken tetiklenen event'dir. İstersek bu aşamada formun kapatılmasını iptal edebiliriz
            Debug.WriteLine("FormClosing tetiklendi...");

            DialogResult result = MessageBox.Show("Kapatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form kapama işlemi gerçekleştikten sonra tetiklenen event'dir. Burada formun neden kapatıldığını öğrenebiliriz. (Kullanıcı tarafından kapatıldı, Bilgisayar kapandığı için kapandı vs. gibi)
            Debug.WriteLine("FormClosed tetiklendi...");
            MessageBox.Show(e.CloseReason.ToString());
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("SizeChanged tetiklendi...");
        }
    }
}
