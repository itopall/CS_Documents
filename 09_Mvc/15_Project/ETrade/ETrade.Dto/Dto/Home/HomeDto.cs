using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.Home
{
    public class HomeDto
    {
        public int NewPurchaseOrderCount { get; set; }

        public int ActiveMemberCount { get; set; }

        public int ActiveProductCount { get; set; }

        public int? ProductClickedCount { get; set; }

        public string DonutChartCategoryList { get; set; }

        public string DonutChartPurchaseQuantityList { get; set; }
    }
}
