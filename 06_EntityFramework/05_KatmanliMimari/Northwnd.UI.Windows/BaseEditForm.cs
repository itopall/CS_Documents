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
    public partial class BaseEditForm : Form
    {
        public BaseEditForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Kategori Ekleme/Güncelleme";
            lblPageDescription.Text = "Yeni bir kategori ekleyebilir ya da var olan bir kategoriyi güncelleyebilirsiniz.";
        }
    }
}
