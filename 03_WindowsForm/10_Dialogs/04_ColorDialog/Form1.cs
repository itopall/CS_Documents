﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ColorDialog'dan seçilen renk bilgisini butonun arkaplan rengi olarak ayarladık!
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                button1.BackColor = colorDialog1.Color;
        }
    }
}
