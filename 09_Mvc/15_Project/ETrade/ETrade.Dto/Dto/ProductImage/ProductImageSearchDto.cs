using ETrade.Dto.Dto.Category;
using ETrade.Dto.Dto.EmployeeType;
using ETrade.Dto.Dto.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.ProductImage
{
    public class ProductImageSearchDto : BaseDto
    {
        [DisplayName("Dosya Adı")]
        public string FileName { get; set; }

        [DisplayName("Dosya Tipi")]
        public string FileType { get; set; }

        public List<ProductImageDto> ProductImages { get; set; }
    }
}
