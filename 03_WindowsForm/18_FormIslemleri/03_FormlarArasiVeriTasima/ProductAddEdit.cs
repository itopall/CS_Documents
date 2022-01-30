using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_FormlarArasiVeriTasima
{
    public partial class ProductAddEdit : Form
    {
        public ProductAddEdit()
        {
            InitializeComponent();
        }

        public ProductAddEdit(string productName)
        {
            InitializeComponent();

            //ctor overload yöntemi
            txtProductName.Text = productName;
        }

        private void ProductAddEdit_Load(object sender, EventArgs e)
        {
            //Static class kullanımı
            //txtProductName.Text = PublicClass.ProductName;
        }
    }
}
