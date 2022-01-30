using ETrade.Dto.Dto.BasketDetail;
using ETrade.Dto.Dto.Category;
using ETrade.Dto.Dto.EmployeeType;
using ETrade.Dto.Dto.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.BasketDetail
{
    public class BasketDetailSearchDto : BaseDto
    {
        public List<BasketDetailDto> BasketDetails { get; set; }
    }
}
