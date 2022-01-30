using ETrade.Dto.Dto.BasketDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.Basket
{
    public class BasketFrontEndDto
    {
        public BasketDto Basket { get; set; }

        public List<BasketDetailDto> BasketDetails { get; set; }
    }
}
