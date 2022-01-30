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
    public partial class ProductAddEdit : BaseAddEdit
    {
        public ProductAddEdit()
        {
            InitializeComponent();
        }

        private void ProductAddEdit_Load(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Ürün Ekleme/Silme/Güncelleme Sayfası";
            lblPageDescription.Text = "Sistemde bulunan ürün kaydını bu sayfa üzerinden düzenleyebilirsiniz ya da yeni bir ürün ekleyebilirsiniz.";
        }
    }
}
