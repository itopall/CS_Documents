using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01_JQueryVeAjaxKullanimi.Models
{
    public class PersonelSearchModel
    {
        public string NameSurname { get; set; }

        public List<PersonelModel> PersonelList { get; set; }
    }
}