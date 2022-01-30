using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01_PartialView.Models
{
    public class BasketModel
    {
        public string NameSurname { get; set; }

        public ProductListModel SepettekiUrunler { get; set; }
    }
}