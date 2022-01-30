using _03_Localization.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Localization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Config'de sakladığımız uygulamanın desteklediği dilleri, dil combobox'ının içerisine ekliyoruz.
            var languages = Settings.Default.Languages.Split(';');
            cbLanguages.Items.AddRange(languages);
        }

        private void cbLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combobox'dan dil değeri değiştirildiğinde ilgili dile ait resource dosyasındaki değerleri formun üzerindeki her bir component'in Text'ine yazıyoruz.
            if (cbLanguages.SelectedItem == null)
                return;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cbLanguages.SelectedItem.ToString());

            foreach (Control control in this.Controls)
            {
                //Combobox'ın text'ini her seferinde clear etmesin diye validasyon ekledik.
                if (control.Name == "cbLanguages")
                    continue;

                control.Text = UI.ResourceManager.GetString(control.Name);
            }
                

            //lblLanguage.Text = UI.lblLanguage;
            //lblUsername.Text = UI.lblUsername;
            //lblPassword.Text = UI.lblPassword;
            //btnLogin.Text = UI.btnLogin;
        }

        string username = "ali";
        string password = "1234";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == username && textBox2.Text == password)
                MessageBox.Show(UI.loginSuccessMessage);
            else
                MessageBox.Show(UI.loginErrorMessage);
        }
    }
}
