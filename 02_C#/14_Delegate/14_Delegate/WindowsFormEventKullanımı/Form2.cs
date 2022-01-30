using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormEventKullanımı
{
    public partial class Form2 : Form
    {
        const string _harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        public Form2()
        {
            InitializeComponent();
            ButonlariUret();
        }

        private void ButonlariUret()
        {
            for (int i = 0; i < _harfler.Length; i++)
            {
                Button button = new Button();
                button.Text = _harfler[i].ToString();
                button.Width = 50;
                button.Height = 50;
                button.Location = new Point(50 * i, 10);
                button.Click += butonaTiklandi_Click;
                this.Controls.Add(button);
            }
            
        }
        private void butonaTiklandi_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            MessageBox.Show($"{senderButton.Text} butona tıklandı");

        }
    }
}
