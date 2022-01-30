using ETrade.Dto.Dto.Category;
using ETrade.Dto.Dto.EmployeeType;
using ETrade.Dto.Dto.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.PurchaseOrder
{
    public class PurchaseOrderSearchDto : BaseDto
    {
        //[DisplayName("Kategori Adı")]
        //public string Name { get; set; }

        public List<PurchaseOrderDto> PurchaseOrders { get; set; }
    }
}
