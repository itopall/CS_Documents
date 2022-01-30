using ETrade.Dto.Dto.BasketDetail;
using ETrade.Dto.Dto.EmployeeType;
using ETrade.Dto.Dto.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.Basket
{
    public class BasketDto : BaseDto
    {
        [Required(ErrorMessage = "Üye boş bırakılamaz!")]
        [DisplayName("Üye")]
        public int MemberId { get; set; }

        public MemberDto Member { get; set; }

        public List<BasketDetailDto> BasketDetail { get; set; }

        //public List<PurchaseOrderDto> PurchaseOrder { get; set; }
        //public List<PurchaseOrderHistoryDto> PurchaseOrderHistory { get; set; }
    }
}
