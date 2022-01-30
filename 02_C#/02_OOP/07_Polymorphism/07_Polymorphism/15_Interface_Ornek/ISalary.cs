using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface_Ornek
{
    interface ISalary
    {
        //ne kadar maaş aldığını tuttuğumuz property
        double salary { get; set; }

        void Salary();
    }
}
