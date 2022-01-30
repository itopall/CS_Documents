using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01_Filters.Models
{
    public class PersonelModel
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}