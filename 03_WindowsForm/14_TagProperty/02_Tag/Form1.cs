using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Tag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Tag = "Yellow";
            radioButton2.Tag = "Green";
            radioButton3.Tag = "Red";
            radioButton4.Tag = "Blue";
            radioButton5.Tag = "Orange";
        }

        //Tag property'si sayesinde aşağıdaki gibi her bir kontrole event yazmak zorunda kalmadan tek bir event ile Tag property'sindeki renk bilgisini okuyup BackColor'a uygulanmasını sağladık.
        private void RenkDegistir_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                BackColor = Color.FromName(rb.Tag.ToString());
        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    BackColor = Color.Yellow;
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //    BackColor = Color.Green;
        //}

        //private void radioButton3_CheckedChanged(object sender, EventArgs e)
        //{
        //    BackColor = Color.Red;
        //}

        //private void radioButton4_CheckedChanged(object sender, EventArgs e)
        //{
        //    BackColor = Color.Blue;
        //}

        //private void radioButton5_CheckedChanged(object sender, EventArgs e)
        //{
        //    BackColor = Color.Orange;
        //}
    }
}
