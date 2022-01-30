using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //1.  Yöntem
            //if (checkBox1.Checked)
            //{
            //    textBox1.Enabled = true;
            //    textBox2.Enabled = true;
            //    textBox3.Enabled = true;
            //    textBox4.Enabled = true;
            //    textBox5.Enabled = true;
            //}
            //else
            //{
            //    textBox1.Enabled = false;
            //    textBox2.Enabled = false;
            //    textBox3.Enabled = false;
            //    textBox4.Enabled = false;
            //    textBox5.Enabled = false;
            //}

            //2. Yöntem
            //textBox1.Enabled = checkBox1.Checked;
            //textBox2.Enabled = checkBox1.Checked;
            //textBox3.Enabled = checkBox1.Checked;
            //textBox4.Enabled = checkBox1.Checked;
            //textBox5.Enabled = checkBox1.Checked;

            panel1.Enabled = checkBox1.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Açılışta editlenebilir olsun.
            checkBox1.Checked = true;
        }

        private void btnBilgiVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Parent.Name);
            MessageBox.Show(panel1.Parent.Name);

            //textbox1 formun Controls koleksiyonuna eklenmemiştir.
            //Panel1'in controls koleksiyonuna eklenmiştir.
            //Dolayısıyla textbox1'in Parent'ı Panel1'dir.

            //Panel1 Form'a eklenöiştir. Dolayısıyla Panel1'in Parent'ı Form1'dir.
            //Form1 hiçbir kontrolün Controls koleksiyonunda yoktur, dolayısıyla Parent'ı null gelir.
        }

        private void btnPanelUret_Click(object sender, EventArgs e)
        {
            //Bir panel nesnesi ürettik
            //Panel'in içine Controls.Add diyerek 3 tane button nesnesi ekledik
            //Panel'i de Controls.Add diyerek formun içerisine ekledik

            Panel panel2 = new Panel();
            panel2.Name = "pnlNew";
            panel2.Width = 1000;
            panel2.Height = 1000;

            panel2.Controls.Add(new Button { Text = "Ürün Ekle", Location = new Point(0, 10) });
            panel2.Controls.Add(new Button { Text = "Sepete Git", Location = new Point(0, 40) });
            panel2.Controls.Add(new Button { Text = "Sipariş Ver", Location = new Point(0, 70) });

            //panel1'in içindeki textbox'ı panel2'nin içerisine taşıdık.
            panel2.Controls.Add(textBox5);
            textBox5.Location = new Point(0, 100);


            panel2.Location = new Point(300, 60);
            this.Controls.Add(panel2);
        }
    }
}
