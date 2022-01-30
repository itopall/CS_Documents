using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Enitty.Entity
{
    class ProductEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }

        public string ProductFullName { get; set; }

        public override string ToString()
        {
            return string.Format($"{ProductId} - {ProductName} - {UnitPrice}");
        }
    }
}
