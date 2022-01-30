using ETrade.Dto.Dto.Category;
using ETrade.Dto.Dto.EmployeeType;
using ETrade.Dto.Dto.ProductImage;
using ETrade.Dto.Dto.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.Product
{
    public class ProductDto : BaseDto
    {
        [Required(ErrorMessage = "Kategori boş bırakılamaz!")]
        [Range(1, 10000000, ErrorMessage = "Minimum 1 Maksimum 1000 olarak değer girebilirsiniz!")]
        [DisplayName("Kategori")]
        public Nullable<int> CategoryId { get; set; }

        [Required(ErrorMessage = "Tedarikçi boş bırakılamaz!")]
        [Range(1, 10000000, ErrorMessage = "Minimum 1 Maksimum 1000 olarak değer girebilirsiniz!")]
        [DisplayName("Tedarikçi")]
        public Nullable<int> SupplierId { get; set; }

        [Required(ErrorMessage = "Ürün Adı boş bırakılamaz!")]
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Geliş Fiyatı boş bırakılamaz!")]
        [DisplayName("Geliş Fiyatı")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal InPrice { get; set; }

        [Required(ErrorMessage = "Satış Fiyatı boş bırakılamaz!")]
        [DisplayName("Satış Fiyatı")]
        public Nullable<decimal> OutPrice { get; set; }

        [DisplayName("İndirimli Fiyat")]
        public Nullable<decimal> DiscountPrice { get; set; }

        [Required(ErrorMessage = "Stok Sayısı boş bırakılamaz!")]
        [DisplayName("Stok Sayısı")]
        public Nullable<int> StockCount { get; set; }

        [DisplayName("Tıklanma Sayısı")]
        public Nullable<int> ClickedCount { get; set; }

        [DisplayName("Aktif Mi")]
        public bool IsActive { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        public CategoryDto Category { get; set; }
        public SupplierDto Supplier { get; set; }

        public List<ProductImageDto> ProductImage { get; set; }

        //For View
        public List<CategoryDto> CategoryList { get; set; }
        public List<SupplierDto> SupplierList { get; set; }
    }
}
