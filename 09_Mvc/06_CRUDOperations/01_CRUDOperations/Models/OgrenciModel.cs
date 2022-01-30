using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace _01_CRUDOperations.Models
{
    public class OgrenciModel
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Bolum { get; set; }
    }
}