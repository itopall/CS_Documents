using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_FolderBrowser
{
    //Klasöre gözat şeklindeki popup penceresini kullanabilmemize olanak sağlar.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Başlangıç klasörü olarak Belgelerim'i seçtik
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyDocuments;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Seçilen Path: " + folderBrowserDialog1.SelectedPath);
        }
    }
}
