using Northwnd.Dto.Dto;
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
    public partial class CategoryEdit : BaseEditForm
    {
        int CategoryId = 0;
        ICategoriesService categoriesService;

        //Insert işlemi için parametre almayan ctor bıraktık.
        public CategoryEdit()
        {
            InitializeComponent();
            categoriesService = new CategoriesService();
        }
        
        //Update işlemi için CategoryId'yi parametre olarak alan ctor yazdık.
        public CategoryEdit(int categoryId)
        {
            InitializeComponent();

            CategoryId = categoryId;
            categoriesService = new CategoriesService();
        }

        private void CategoryEdit_Load(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Kategori Ekleme/Güncelleme";
            lblPageDescription.Text = "Yeni bir kategori ekleyebilir ya da var olan bir kategoriyi güncelleyebilirsiniz.";

            //CategoryId 0'dan büyükse update işlemi gerçekleştirileceği için update edeceğimiz kaydın son güncel halini CategoryId'yi göre db'den çekiyoruz.
            if (CategoryId > 0)
            {
                LoadCategory();
            }
        }

        private void LoadCategory()
        {
            var categoryDto = categoriesService.GeyById(CategoryId);
            if (categoryDto != null)
            {
                txtCategoryId.Text = categoryDto.CategoryID.ToString();
                txtCategoryName.Text = categoryDto.CategoryName;
                txtCategoryDescription.Text = categoryDto.Description;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                return;
            }

            Save();
        }

        private bool Validate()
        {
            bool result = true;
            if (txtCategoryName.Text.Length > 15)
            {
                result = false;
                MessageBox.Show("Kategori Adı 15 karakterden büyük olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        private void Save()
        {
            CategoriesDto categoriesDto = new CategoriesDto();
            categoriesDto.CategoryName = txtCategoryName.Text;
            categoriesDto.Description = txtCategoryDescription.Text;

            try
            {
                if (CategoryId > 0)
                {
                    //Güncelleme işlemi gerçekleştirilir
                    categoriesDto.CategoryID = CategoryId;
                    categoriesService.Update(categoriesDto);
                }
                else
                {
                    //Insert işlemi gerçekleştirilir.
                    categoriesService.Add(categoriesDto);
                }

                MessageBox.Show("Kaydetme işlemi başarıyla tamamlandı...");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu! Hata detayı: \r\n" + ex.Message);
            }
        }
    }
}
