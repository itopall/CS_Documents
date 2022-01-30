using Northwnd.Service.Service;
using Northwnd.UI.Windows.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwnd.UI.Windows
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IEmployeesService employeesService = new EmployeesService();
            var dto = employeesService.Login(txtUsername.Text);
            if (dto != null)
            {
                CacheManager.LoginEmployee = dto;

                this.Hide();

                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Girdiğiniz kullanıcı adı hatalı!");
            }
        }
    }
}
