using Northwnd.Service.Service;
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
    public partial class CategoriesList : BaseListForm
    {
        ICategoriesService categoryService;
        public CategoriesList()
        {
            InitializeComponent();

            categoryService = new CategoriesService();
        }

        private void CategoriesList_Load(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Kategori Listeleme";
            lblPageDescription.Text = "Sistemde bulunan bütün kategorileri bu ekran üzerinden görüntüleyebilirsiniz.";

            grdList.AutoGenerateColumns = false;
            LoadList();
        }

        private void LoadList()
        {
            grdList.DataSource = categoryService.GetAll();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CategoryEdit form = new CategoryEdit();
            form.ShowDialog();

            //Kaydetme işlemi tamamlandıktan sonra listeyi güncelliyoruz.
            LoadList();
        }

        private void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                int categoryId = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["CategoryId"].Value);
                CategoryEdit(categoryId);
            }
        }

        private void grdList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int categoryId = Convert.ToInt32(grdList.Rows[e.RowIndex].Cells["CategoryId"].Value);

            //YÖNTEM 1
            //if (e.ColumnIndex == 3)
            //{
            //     CategoryEdit(categoryId);
            //}
            //else if (e.ColumnIndex == 4)
            //{
            //    CategoryDelete(categoryId);
            //}

            //YÖNTEM 2
            if (grdList.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var button = (DataGridViewButtonColumn)grdList.Columns[e.ColumnIndex];

                if (button.Name == "Edit")
                {
                    CategoryEdit(categoryId);
                }
                else if (button.Name == "Delete")
                {
                    CategoryDelete(categoryId);
                }
            }
        }

        private void CategoryDelete(int categoryId)
        {
            DialogResult dialogResult = MessageBox.Show(categoryId + " id'li kategori silinecek! Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    categoryService.Delete(categoryId);

                    //Silme işlemi tamamlandıktan sonra listeyi güncelliyoruz.
                    LoadList();

                    MessageBox.Show("Silme işlemi başarıyla tamamlandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu! Hata detayı: \r\ne" + ex.InnerException.InnerException.Message);
                }
            }
        }

        private void CategoryEdit(int categoryId)
        {
            CategoryEdit form = new CategoryEdit(categoryId);
            form.ShowDialog();

            //Güncelleme işlemi tamamlandıktan sonra listeyi güncelliyoruz.
            LoadList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                LoadList();
            }
            else
            {
                LoadSearch();
            }
        }

        private void LoadSearch()
        {
            var list = categoryService.GetByName(txtCategoryName.Text);
            grdList.DataSource = list;
        }
    }
}
