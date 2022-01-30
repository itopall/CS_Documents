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
    public partial class ProductList : BaseList
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Ürün Yönetim Sayfası";
            lblPageDescription.Text = "Sistemde bulunan ürünleri bu sayfa üzerinden yönetebilirsiniz.";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ProductAddEdit form = new ProductAddEdit();
            form.ShowDialog();
        }
    }
}
