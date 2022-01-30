using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto
{
    public class EmployeeDto : BaseDto
    {
        public Nullable<int> EmployeeTypeId { get; set; }
        public Nullable<int> ManagerEmployeeId { get; set; }
        public string Namesurname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RelatedPhone { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<bool> Gender { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
    }
}
