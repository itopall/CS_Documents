using ETrade.Dto.Dto.EmployeeType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.Employee
{
    public class EmployeeSearchDto : BaseDto
    {
        [DisplayName("Personel Tipi")]
        public Nullable<int> EmployeeTypeId { get; set; }

        [DisplayName("Müdür")]
        public Nullable<int> ManagerEmployeeId { get; set; }

        [DisplayName("İsim soyisim")]
        public string Namesurname { get; set; }

        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Telefon")]
        public string Phone { get; set; }

        public List<EmployeeDto> Employees { get; set; }

        //For DropDownList
        public List<EmployeeTypeDto> EmployeeTypeList { get; set; }
        public List<EmployeeDto> EmployeeList { get; set; }
    }
}
