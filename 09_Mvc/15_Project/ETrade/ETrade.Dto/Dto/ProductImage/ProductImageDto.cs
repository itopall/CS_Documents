using ETrade.Dto.Dto.EmployeeType;
using ETrade.Dto.Dto.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.ProductImage
{
    public class ProductImageDto : BaseDto
    {
        [Required(ErrorMessage = "Ürün boş bırakılamaz!")]
        [Range(1, 10000000, ErrorMessage = "Minimum 1 Maksimum 10000000 olarak değer girebilirsiniz!")]
        [DisplayName("Ürün")]
        public Nullable<int> ProductId { get; set; }

        [DisplayName("Resim Url")]
        public string ImageUrl { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }

        [DisplayName("Aktif Mi")]
        public bool IsActive { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        public ProductDto Product { get; set; }

        //For View
        public List<ProductDto> ProductList { get; set; }
    }
}
