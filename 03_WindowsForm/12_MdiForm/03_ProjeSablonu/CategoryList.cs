using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_ProjeSablonu
{
    public partial class CategoryList : BaseList
    {
        public CategoryList()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CategoryAddEdit form = new CategoryAddEdit();
            form.ShowDialog();
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Kategori Yönetim Sayfası";
            lblPageDescription.Text = "Sistemde bulunan kategoriler bu sayfa üzerinden yönetebilirsiniz.";
        }
    }
}
