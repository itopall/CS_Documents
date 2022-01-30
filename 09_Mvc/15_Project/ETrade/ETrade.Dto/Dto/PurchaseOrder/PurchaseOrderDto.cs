using ETrade.Dto.Dto.EmployeeType;
using ETrade.Dto.Dto.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.PurchaseOrder
{
    public class PurchaseOrderDto : BaseDto
    {
        public Nullable<int> BasketId { get; set; }
        public Nullable<int> MemberId { get; set; }
        public Nullable<int> PaymentTypeId { get; set; }
        public Nullable<int> ShipperId { get; set; }
        public Nullable<int> PurchaseOrderStatusId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<decimal> ShipperPrice { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }

        //public BasketDto Basket { get; set; }
        public MemberDto Member { get; set; }
        //public PaymentTypeDto PaymentType { get; set; }
        //public PurchaseOrderStatusDto PurchaseOrderStatus { get; set; }
        //public ShipperDto Shipper { get; set; }
    }
}
