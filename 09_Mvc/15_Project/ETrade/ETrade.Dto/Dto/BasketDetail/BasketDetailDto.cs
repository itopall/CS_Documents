using ETrade.Dto.Dto.Basket;
using ETrade.Dto.Dto.EmployeeType;
using ETrade.Dto.Dto.Member;
using ETrade.Dto.Dto.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.BasketDetail
{
    public class BasketDetailDto : BaseDto
    {
        public Nullable<int> BasketId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }

        public BasketDto Basket { get; set; }
        public ProductDto Product { get; set; }
    }
}
