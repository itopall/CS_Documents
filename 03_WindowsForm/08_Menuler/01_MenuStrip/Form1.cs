using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_MenuStrip
{
    public partial class Form1 : Form
    {
        //MenuStrip kontrolünün içine çok çeşitli menu nesneleri eklenebilir. Bu nesnelerinm tipi aşağıdakilerden biri olabilir.
        //ToolStripCombobox
        //ToolStripMenuItem
        //ToolStripTextBox
        //ToolStripSeperator

        //Tüm bu menu tipleri ToolStripItem sınıfından kalıtılmıştır.

        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni butonuna tıklandı.");
        }

        private void excelExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excel'e export edildi.");
        }

        private void pdfExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pdf'e export edildi.");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
