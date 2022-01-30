using ETrade.Dto.Dto.Category;
using ETrade.Dto.Dto.EmployeeType;
using ETrade.Dto.Dto.Product;
using ETrade.Dto.Dto.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.Product
{
    public class ProductSearchDto : BaseDto
    {
        [DisplayName("Kategori")]
        public Nullable<int> CategoryId { get; set; }

        [DisplayName("Tedarikçi")]
        public Nullable<int> SupplierId { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [DisplayName("Geliş Fiyatı Aralığı")]
        public Nullable<decimal> InPriceStart { get; set; }

        public Nullable<decimal> InPriceEnd { get; set; }

        [DisplayName("Satış Fiyatı Aralığı")]
        public Nullable<decimal> OutPriceStart { get; set; }

        public Nullable<decimal> OutPriceEnd { get; set; }

        public List<ProductDto> Products { get; set; }


        //For DropDownList
        public List<CategoryDto> CategoryList { get; set; }

        public List<SupplierDto> SupplierList { get; set; }
    }
}
