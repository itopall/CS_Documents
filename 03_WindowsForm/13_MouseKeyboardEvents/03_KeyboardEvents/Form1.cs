using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_KeyboardEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    pictureBox1.Top -= 5;
                    break;
                case Keys.Down:
                    pictureBox1.Top += 5;
                    break;
                case Keys.Left:
                    pictureBox1.Left -= 5;
                    break;
                case Keys.Right:
                    pictureBox1.Left += 5;
                    break;
                case Keys.Space:
                    sayac = 1;
                    timer1.Start();
                    break;
                default:
                    break;
            }
        }

        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac <= 30)
            {
                pictureBox1.Left += 5;
                sayac++;

                pictureBox1.Top -= 5;
            }
            else if(sayac <=60)
            {
                pictureBox1.Left -= 5;
                sayac++;

                pictureBox1.Top += 5;
            }
            else
            {
                timer1.Stop();
                sayac = 0;
            }
        }
    }
}
