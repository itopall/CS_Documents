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
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            if (lstProductList.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce güncellemek istediğiniz ürünü seçiniz!");
                return;
            }

            //Yöntem 1: Static class kullanımı
            //PublicClass.ProductName = lstProductList.SelectedItem.ToString();
            //ProductAddEdit form = new ProductAddEdit();
            //form.ShowDialog();

            //Yöntem 2: Ctor Overload kullanımı
            ProductAddEdit form = new ProductAddEdit(lstProductList.SelectedItem.ToString());
            form.ShowDialog();
        }
    }
}
