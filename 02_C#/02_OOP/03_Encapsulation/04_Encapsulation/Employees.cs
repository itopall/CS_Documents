using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation
{
    class Employees
    {
        //Erişim belirleyicisi private Field'lar oluşturduk.
        private int EmployeeId;
        private string FirstName = "İlker";
        private string LastName;
        private string DepartmentName;
        private string Title;

        //Sağ tık yaparak  encapsulation yaparak propertyleri oluşturduk
        public int EmployeeId1 { get => EmployeeId; set => EmployeeId = value; }
        public string FirstName1 { get => FirstName = "hasan";}//bunu yazarsak bu geçerli olur yu karıdaki değil
        public string LastName1 { set => LastName = value; }
        public string DepartmentName1 { get => DepartmentName; set => DepartmentName = value; }
        public string Title1 { get => Title; set => Title = value; }
    }
}
