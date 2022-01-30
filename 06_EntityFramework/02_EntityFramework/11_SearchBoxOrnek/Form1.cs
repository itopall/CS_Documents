using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_SearchBoxOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Products> list;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            NORTHWNDEntities context = new NORTHWNDEntities();
            list = context.Products.ToList();

            grdProducts.DataSource = list;
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            grdProducts.DataSource = list.Where(p => p.ProductName.ToLower().Contains(txtProductName.Text.ToLower())).ToList();
        }

        private void grdProducts_DataSourceChanged(object sender, EventArgs e)
        {
            LoadDetail();
        }

        private void LoadDetail()
        {
            List<Products> filteredList = (List<Products>)grdProducts.DataSource;

            if (filteredList.Count > 0)
            {
                lblMaxPrice.Text = filteredList.Max(p => p.UnitPrice).ToString();
                lblMinPrice.Text = filteredList.Min(p => p.UnitPrice).ToString();
                lblSumPrice.Text = filteredList.Sum(p => p.UnitPrice).ToString();
            }
            else
            {
                lblMaxPrice.Text = "0";
                lblMinPrice.Text = "0";
                lblSumPrice.Text = "0";
            }
        }
    }
}
