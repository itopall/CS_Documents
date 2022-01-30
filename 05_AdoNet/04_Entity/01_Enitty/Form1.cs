using _01_Enitty.Data;
using _01_Enitty.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Enitty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<ProductEntity> _products;
        private void Form1_Load(object sender, EventArgs e)
        {
            ProductManagement pm = new ProductManagement();
            _products = pm.GetProducts();
            BindProducts();
            GetProductsCount();
            GetProductSumPrice();
        }

        private void BindProducts()
        {
            #region 1. Yöntem
            //lstProducts.ValueMember = "ProductId";
            //lstProducts.DisplayMember = "ProductName";
            //foreach (var p in _products)
            //    lstProducts.Items.Add(p);
            #endregion

            #region 2. Yöntem
            //Eğer Valuemember ve DisplayMember bilgileri verilmeze Product entity nesnesinin ToString edilmesi sonucunda ne görünüyorsa listbox'ın içine de o bilgi basılır. ProductEntity nesnesi içerisinde ToString methodu override edilerek özelleştirilebilir.
            //lstProducts.ValueMember = "ProductId";
            //lstProducts.DisplayMember = "ProductFullName";

            //Bir veritabanı kontrolüne, IList interface'ini implement etmiş herhangi bir nesne Veri kaynağı olarak atanabilir.
            lstProducts.DataSource = _products;
            #endregion
        }

        private void GetProductsCount()
        {
            lblProductCount.Text = _products.Count.ToString();
        }

        private void GetProductSumPrice()
        {
            //Linq konularına gelindiğinde daha pratik yöntemle bu tür işlemleri yapabileceğiz.
            decimal sum = 0;
            foreach (var p in _products)
                sum += p.UnitPrice;

            lblSumPrice.Text = sum.ToString("C");
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listbox'a DataSource olarak List<ProductEntity> verdiğimizden dolayı, içindeki her eleman bir ProductEntity nesnesidir. Dolayısıyla SelectedItem geriye ProductEntity nesnesini döner
            var productEntity = (ProductEntity)lstProducts.SelectedItem;

            //Override edilen ToString methodu tetiklenir ve formatlı olarak yazdırılır.
            this.Text = productEntity.ToString();
        }
    }
}
