using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_MouseEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Mouse panel'in üstünde tıklandığı anda tetiklenir.
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Height += 100;
            panel1.Width += 100;
        }

        //Mouse panel'in üstünde tıklama bırakıldığı anda tetiklenir.
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            panel1.Height -= 100;
            panel1.Width -= 100;
        }

        //Mouse panel'in üstüne geldiği anda tetiklenir
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        //Mouse panel'in üstünden ayrıldığı anda tetiklenir.
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Aqua;
        }

        //Mouse panel'in üstüne gelip durduğunda tetiklenir.
        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
        }

        //Mouse panel'in üstüne tek tıklandığında tetiklenir.
        private void panel1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click tetiklendi.");
        }

        //Mouse panel'in üstüne çift tıklandığında tetiklenir.
        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("DoubleClick tetiklendi.");
        }

        //Mouse panel'in üstünde her hareket ettiğinde tetiklenir.
        int sayac = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            sayac++;
            listBox1.Items.Add("Move Tetiklendi => " + sayac);
        }

        //Mouse formun üstünde tıklandığı anda tetiklenir.
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"X: {e.X}, Y: {e.Y}");
        }
    }
}
