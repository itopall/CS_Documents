using ETrade.Dto.Dto.Category;
using ETrade.Dto.Dto.EmployeeType;
using ETrade.Dto.Dto.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.Basket
{
    public class BasketSearchDto : BaseDto
    {
        public List<BasketDto> Baskets { get; set; }
    }
}
