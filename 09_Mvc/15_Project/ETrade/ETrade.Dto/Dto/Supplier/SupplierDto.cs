using ETrade.Dto.Dto.EmployeeType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.Supplier
{
    public class SupplierDto : BaseDto
    {
        [Required(ErrorMessage = "Tedarikçi Adı boş bırakılamaz!")]
        [DisplayName("Tedarikçi Adı")]
        public string Name { get; set; }

        [DisplayName("Aktif Mi")]
        public bool IsActive { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }
    }
}
