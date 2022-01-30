using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01_PartialView.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCampaign { get; set; }
        public bool IsInBasket { get; set; }
    }
}