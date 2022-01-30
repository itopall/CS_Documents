using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_TextControls
{
    public partial class Form1 : Form
    {
        List<Kullanici> kullanicilar = new List<Kullanici>
        {
            new Kullanici { Id = 1, UserName = "rustu", Password = "1111" },
            new Kullanici { Id = 2, UserName = "berat", Password = "2222" },
            new Kullanici { Id = 3, UserName = "utku", Password = "3333" },
            new Kullanici { Id = 4, UserName = "omer", Password = "4444" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (Kullanici kullanici in kullanicilar)
            {
                if (txtUsername.Text == kullanici.UserName && txtPassword.Text == kullanici.Password)
                {
                    MessageBox.Show("Giriş işlemi başarılı, anasayfaya yönlendiriliyorsunuz...");
                    this.Hide();

                    MainForm mainForm = new MainForm();
                    mainForm.Show();

                    return;
                }
            }

            MessageBox.Show("Kullanıcı adı ya da şifre hatalı!");
        }

        class Kullanici
        {
            public int Id { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
