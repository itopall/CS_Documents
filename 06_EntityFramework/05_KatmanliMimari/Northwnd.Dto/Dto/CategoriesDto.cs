using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Dto.Dto
{
    public class CategoriesDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        //Dto'nun içerisine Entity'den farklı yeni alanlar da eklenebilir.
        //public int CategoryCount { get; set; }
    }
}
